using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataLibraryDMD
{ 
    public class MantenimentDades
    {
        protected string _connectionString = "Data Source=sqlserver.S2AM.sdslab.cat;Initial Catalog=SecureCoreG4;Persist Security Info=True;User ID=G4;Password=12345G4aA2425.";

        private SqlConnection connection;
        private DataSet ds;

        public MantenimentDades()
        {
            connection = new SqlConnection(_connectionString);
        }

        //public SqlConnection Connectar()
        //{
        //    connection.Open();
        //}

        public DataSet PortarTaula(string nomTaula)
        {
            ds = new DataSet();

            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM {nomTaula}", connection);
            da.Fill(ds, nomTaula);

            connection.Close();
            
            return ds;
        }

        public DataSet PortarPerConsulta(string query)
        {
            ds = new DataSet();

            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds);

            connection.Close();
            
            return ds;
        }

        public DataSet PortarPerConsulta(string query, string nomDataTable)
        {

            ds = new DataSet();

            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            da.Fill(ds, nomDataTable);

            connection.Close();

            return ds;
        }

        public int Actualitzar(string querySelect, DataSet ds, string nomTaula)
        {

            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(querySelect, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            int result = da.Update(ds.Tables[nomTaula]);

            connection.Close();

            return result;
        }

        public int Executa(string query)
        {
            int rowsAffected;

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            rowsAffected = command.ExecuteNonQuery();

            connection.Close();
            
            return rowsAffected;
        }

        
    }

}
