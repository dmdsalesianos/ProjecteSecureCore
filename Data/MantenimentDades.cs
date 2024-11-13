using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows;

namespace DataLibraryDMD
{
    public class MantenimentDades
    {

        protected string connectionString;

        public MantenimentDades(string connString)
        {
            connectionString = connString;
        }

        public SqlConnection Connectar()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public string ObtenerConnectionString()
        {
            ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["Conexio"];
            if (connectionStringSettings == null)
            {
                throw new InvalidOperationException("No se pudo encontrar la cadena de conexión 'Conexio'.");
            }

            return connectionStringSettings.ConnectionString;
        }

        public DataSet PortarTaula(string tableName)
        {
            SqlConnection conn = Connectar();
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM {tableName}", conn);
            da.Fill(ds, tableName);
            conn.Close();
            return ds;
        }

        public DataSet PortarPerConsulta(string query)
        {
            SqlConnection conn = Connectar();
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet PortarPerConsulta(string query, string tableName)
        {
            SqlConnection conn = Connectar();
            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, tableName);
            conn.Close();
            return ds;
        }

        public void Actualitzar(System.Data.DataSet ds, string query, string tableName)
        {
            SqlConnection conn = Connectar();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            da.Update(ds, tableName);
            conn.Close();
        }


        public void Executa(string query)
        {
            SqlConnection conn = Connectar();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }

}
