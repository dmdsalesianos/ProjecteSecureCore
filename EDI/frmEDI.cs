using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDI
{
    public partial class frmEDI : Form
    {
        SecureCoreG4Entities entities;
        Order newOrder;
        OrderInfo newOrderInfo;
        OrdersDetail newOrderDetail;
        List<OrdersDetail> OrdersDetails;
        string selectedFile;
        public frmEDI()
        {
            InitializeComponent();

            entities = new SecureCoreG4Entities();

            OrdersDetails = new List<OrdersDetail>();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "FTP"); // Cambia esto por la ruta deseada
                openFileDialog.Filter = "Archivos EDI (*.edi)|*.edi";
                openFileDialog.Title = "Seleccionar un archivo EDI";
                openFileDialog.Multiselect = false; // Permite seleccionar solo un archivo

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rtbDoc.AppendText("Processing File...\n");
                    rtbDoc.AppendText("______________________________________\n");

                    selectedFile = openFileDialog.FileName;
                    
                    using (StreamReader reader = new StreamReader(selectedFile))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {

                            string[] partes = line.Split('|');

                            if (partes[0] == "ORD")
                            {
                                newOrder = new Order();

                                newOrder.codeOrder = partes[1];

                                string codePriority = partes[2];
                                short id = entities.Priorities.FirstOrDefault(p => p.CodePriority == codePriority).idPriority;

                                newOrder.IdPriority = entities.Priorities.FirstOrDefault(p => p.CodePriority == codePriority).idPriority;

                            }
                            else if (partes[0] == "DTM")
                            {
                                string dateOrder = partes[1];
                                newOrder.dateOrder = DateTime.ParseExact(dateOrder, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                            }
                            else if (partes[0] == "NADMS")
                            {
                                newOrderInfo = new OrderInfo();

                                newOrderInfo.idOrder = newOrder.idOrder;

                                string CodeOperationalArea = partes[1];
                                newOrderInfo.idOperationalArea = entities.OperationalAreas.FirstOrDefault(p => p.CodeOperationalArea == CodeOperationalArea).idOperationalArea;
                                string CodeAgency = partes[2];
                                newOrderInfo.idAgency = entities.Agencies.FirstOrDefault(p => p.CodeAgency == CodeAgency).idAgency;
                            }
                            else if (partes[0] == "NADMR")
                            {
                                string codeFactory = partes[1];
                                newOrder.IdFactory = entities.Factories.FirstOrDefault(p => p.codeFactory == codeFactory).idFactory;
                            }
                            else if (partes[0] == "LIN")
                            {
                                newOrderDetail = new OrdersDetail();

                                newOrderDetail.idOrder = newOrder.idOrder;
                                string CodePlanet = partes[1];
                                newOrderDetail.idPlanet = entities.Planets.FirstOrDefault(p => p.CodePlanet == CodePlanet).idPlanet;
                                string codeReference = partes[2];
                                newOrderDetail.idReference = entities.References.FirstOrDefault(p => p.codeReference == codeReference).idReference;
                            }
                            else if (partes[0] == "QTYLIN")
                            {
                                newOrderDetail.Quantity = short.Parse(partes[2]);
                            }
                            else if (partes[0] == "DTMLIN")
                            {
                                string DeliveryDate = partes[1];
                                newOrderDetail.DeliveryDate = DateTime.ParseExact(DeliveryDate, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                                OrdersDetails.Add(newOrderDetail);
                            }

                            line = "";
                        }
                    }


                    entities.Orders.Add(newOrder);
                    entities.OrderInfoes.Add(newOrderInfo);
                    foreach (OrdersDetail ordersDetail in OrdersDetails)
                    {
                        entities.OrdersDetails.Add(ordersDetail);
                    }

                    rtbDoc.AppendText($"Order: {newOrder.codeOrder}\n");
                    rtbDoc.AppendText($"Priority: {newOrder.Priority.DescPriority}\n");
                    rtbDoc.AppendText($"Date Order: {newOrder.dateOrder}\n");
                    rtbDoc.AppendText($"Zona Operativa: {newOrderInfo.OperationalArea.DescOperationalArea}\n");
                    rtbDoc.AppendText($"Agency: {newOrderInfo.Agency.DescAgency}\n");
                    rtbDoc.AppendText($"Factory: {newOrder.Factory.DescFactory}\n");
                    rtbDoc.AppendText($"Zona Operativa: {newOrderInfo.OperationalArea.DescOperationalArea}\n");

                    rtbDoc.AppendText("PRODUCTOS:\n");
                    foreach (OrdersDetail ordersDetail in OrdersDetails)
                    {
                        int i = 1;
                        rtbDoc.AppendText($"- Product:{ordersDetail.Reference.descReference}\n");
                        rtbDoc.AppendText($"    Quantity: {ordersDetail.Quantity}\n");
                        rtbDoc.AppendText($"    Planet:{ordersDetail.Planet.DescPlanet}\n");
                        rtbDoc.AppendText($"    Delivery Date: {ordersDetail.DeliveryDate}\n");
                        i++;
                    }

                    rtbDoc.AppendText("______________________________________\n");
                }
            }
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            string destino = Path.Combine(Path.GetDirectoryName(selectedFile), "tractats", Path.GetFileName(selectedFile));
            File.Move(selectedFile, destino);

            entities.SaveChanges();

            rtbDoc.AppendText("Order made!\n");

        }
    }
}
