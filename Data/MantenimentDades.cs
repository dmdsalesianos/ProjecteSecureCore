using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataAccess
{
    /// <summary>
    /// Clase para realizar operaciones de mantenimiento de datos en una base de datos SQL.
    /// </summary>
    /// <remarks>
    /// Esta clase ofrece funcionalidades como consultas, actualizaciones y ejecución de transacciones
    /// en una base de datos SQL mediante ADO.NET.
    /// </remarks>
    public class MantenimentDades
    {
        /// <summary>
        /// Cadena de conexión a la base de datos.
        /// </summary>
        protected string _connectionString;

        private SqlConnection connection;
        private DataSet ds;
        private SqlTransaction transaction;

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="MantenimentDades"/> con la cadena de conexión especificada.
        /// </summary>
        /// <param name="connectionString">La cadena de conexión a la base de datos.</param>
        /// <remarks>
        /// Este constructor crea una nueva instancia de la clase <see cref="MantenimentDades"/> y establece
        /// la conexión a la base de datos usando la cadena de conexión proporcionada.
        /// </remarks>
        public MantenimentDades(string connectionString)
        {
            _connectionString = connectionString;
            connection = new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Obtiene todos los registros de una tabla especificada en la base de datos.
        /// </summary>
        /// <param name="nomTaula">Nombre de la tabla a obtener.</param>
        /// <returns>
        /// Un <see cref="DataSet"/> que contiene los datos de la tabla.
        /// Si ocurre un error, devuelve <c>null</c>.
        /// </returns>
        /// <remarks>
        /// Este método abre una conexión con la base de datos y ejecuta una consulta SELECT para obtener
        /// todos los registros de la tabla especificada. Los resultados se devuelven en un <see cref="DataSet"/>.
        /// </remarks>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// MantenimentDades db = new MantenimentDades(connectionString);
        /// DataSet result = db.PortarTaula("Clientes");
        /// </code>
        /// </example>
        public DataSet PortarTaula(string nomTaula)
        {
            ds = new DataSet();

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM {nomTaula}", connection);
                da.Fill(ds, nomTaula);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la tabla {nomTaula}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds = null;
            }
            finally
            {
                connection.Close();
            }

            return ds;
        }

        /// <summary>
        /// Ejecuta una consulta SQL y devuelve los resultados como un <see cref="DataSet"/>.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <returns>
        /// Un <see cref="DataSet"/> que contiene los datos resultantes de la consulta.
        /// Si ocurre un error, devuelve <c>null</c>.
        /// </returns>
        /// <remarks>
        /// Este método permite ejecutar cualquier consulta SQL que no esté directamente relacionada
        /// con una tabla específica. Los resultados se devuelven en un <see cref="DataSet"/>.
        /// </remarks>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string query = "SELECT * FROM Clientes WHERE Edad > 30";
        /// DataSet result = db.PortarPerConsulta(query);
        /// </code>
        /// </example>
        public DataSet PortarPerConsulta(string query)
        {
            ds = new DataSet();

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds = null;
            }
            finally
            {
                connection.Close();
            }

            return ds;
        }

        /// <summary>
        /// Actualiza la base de datos utilizando un conjunto de datos y una consulta SELECT.
        /// </summary>
        /// <param name="querySelect">La consulta SELECT para seleccionar los datos a actualizar.</param>
        /// <param name="ds">El <see cref="DataSet"/> que contiene los cambios a aplicar en la base de datos.</param>
        /// <param name="nomTaula">El nombre de la tabla en el <see cref="DataSet"/>.</param>
        /// <returns>
        /// El número de filas afectadas por la actualización. Devuelve <c>-1</c> si ocurre un error.
        /// </returns>
        /// <remarks>
        /// Este método realiza una actualización en la base de datos utilizando un <see cref="DataSet"/>
        /// que contiene las modificaciones a aplicar en la tabla especificada.
        /// </remarks>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// DataSet ds = new DataSet();
        /// ds.Tables["Clientes"].Rows[0]["Nombre"] = "Nuevo Nombre";
        /// int result = db.Actualitzar("SELECT * FROM Clientes", ds, "Clientes");
        /// </code>
        /// </example>
        public int Actualitzar(string querySelect, DataSet ds, string nomTaula)
        {
            int result = 0;
            SqlTransaction transaction = null;

            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();

                SqlDataAdapter da = new SqlDataAdapter(querySelect, connection);
                da.SelectCommand.Transaction = transaction;

                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                result = da.Update(ds.Tables[nomTaula]);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show($"Error al actualizar la tabla {nomTaula}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = -1; // Si es error devuelve -1
            }
            finally
            {
                connection.Close();
            }

            return result;
        }


        /// <summary>
        /// Ejecuta una consulta SQL no selectiva (INSERT, UPDATE, DELETE).
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <returns>
        /// El número de filas afectadas por la operación. Devuelve <c>-1</c> si ocurre un error.
        /// </returns>
        /// <remarks>
        /// Este método se utiliza para ejecutar consultas que modifican la base de datos, como INSERT,
        /// UPDATE o DELETE. Los resultados devueltos indican cuántas filas fueron afectadas.
        /// </remarks>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// string query = "DELETE FROM Clientes WHERE Edad &lt; 18";
        /// int rowsAffected = db.Executa(query);
        /// </code>
        /// </example>
        public int Executa(string query)
        {
            int rowsAffected;
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la ejecución de la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rowsAffected = -1; // Si es error devuelve -1
            }
            finally
            {
                connection.Close();
            }

            return rowsAffected;
        }


        /// <summary>
        /// Genera una consulta de búsqueda con múltiples criterios y devuelve los resultados en un <see cref="DataSet"/>.
        /// </summary>
        /// <param name="nomTaula">Nombre de la tabla en la que buscar.</param>
        /// <param name="criteris">
        /// Diccionario de criterios de búsqueda, donde la clave es el nombre de la columna y el valor es el valor a buscar.
        /// </param>
        /// <returns>Un <see cref="DataSet"/> con los resultados de la búsqueda. Si ocurre un error, devuelve <c>null</c>.</returns>
        /// <remarks>
        /// Este método genera dinámicamente una consulta SQL para buscar registros en una tabla específica según los criterios proporcionados.
        /// Los nombres de las columnas y valores son incluidos en la consulta de manera segura para prevenir inyecciones SQL.
        /// El nombre de la tabla es validado para garantizar que solo contenga caracteres alfanuméricos y guiones bajos.
        /// </remarks>
        /// <example>
        /// Ejemplo: Generar una consulta de búsqueda con criterios específicos.
        /// <code>
        /// var criteris = new Dictionary&lt;string, string&gt;
        /// {
        ///     { "Login", "MAND" },
        ///     { "Rol", "Admin" }
        /// };
        /// string nomTaula = "Usuarios";
        /// MantenimentDades manteniment = new MantenimentDades(connectionString);
        /// DataSet resultado = manteniment.GeneraConsultaCerca(nomTaula, criteris);
        /// </code>
        /// Esto generará una consulta SQL similar a:
        /// <code>
        /// SELECT * FROM [Usuarios] WHERE 1=1 AND [Login] = 'MAND' AND [Rol] = 'Admin'
        /// </code>
        /// Los valores de los parámetros serán configurados con seguridad para prevenir inyección SQL.
        ///
        /// Ejemplo: Generar una consulta de búsqueda sin criterios.
        /// <code>
        /// string nomTaula = "Usuarios";
        /// MantenimentDades manteniment = new MantenimentDades(connectionString);
        /// DataSet resultado = manteniment.GeneraConsultaCerca(nomTaula, null);
        /// </code>
        /// Esto generará una consulta SQL similar a:
        /// <code>
        /// SELECT * FROM [Usuarios] WHERE 1=1
        /// </code>
        /// </example>

        public DataSet GeneraConsultaCerca(string nomTaula, Dictionary<string, string> criteris)
        {
            ds = new DataSet();

            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = $"SELECT * FROM [{nomTaula}] WHERE 1=1 ";

                foreach (var criteri in criteris)
                {
                    command.CommandText += $"AND [{criteri.Key}] = @Valor";

                    //command.Parameters.Add(new SqlParameter("@Camp", criteri.Key));
                    command.Parameters.Add(new SqlParameter("@Valor", criteri.Value));
                }

                connection.Open();

                SqlDataAdapter dta = new SqlDataAdapter();
                dta.SelectCommand = command;
                dta.Fill(ds);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la generación de la consulta de búsqueda: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds = null;
            }
            finally
            {
                connection.Close();
            }

            return ds;
        }

        /// <summary>
        /// Ejecuta un procedimiento almacenado en la base de datos con parámetros opcionales y devuelve los resultados en un <see cref="DataSet"/>.
        /// </summary>
        /// <param name="nomProc">Nombre del procedimiento almacenado a ejecutar.</param>
        /// <param name="parametres">
        /// Diccionario de parámetros donde la clave es el nombre del parámetro (incluyendo el prefijo `@`) 
        /// y el valor es el valor que se pasará al procedimiento almacenado. Este parámetro puede ser <c>null</c> si el procedimiento no requiere parámetros.
        /// </param>
        /// <returns>
        /// Un <see cref="DataSet"/> que contiene los resultados del procedimiento almacenado. 
        /// Si ocurre un error durante la ejecución, se devuelve <c>null</c>.
        /// </returns>
        /// <remarks>
        /// Este método permite ejecutar procedimientos almacenados en la base de datos, con soporte para parámetros opcionales.
        /// Los parámetros deben pasarse como un diccionario con nombres y valores, donde los nombres coincidan 
        /// exactamente con los esperados por el procedimiento almacenado, incluyendo el prefijo `@`. Si no se requieren parámetros,
        /// se puede pasar <c>null</c> para la variable <paramref name="parametres"/>.
        /// 
        /// El procedimiento almacenado será ejecutado mediante el comando `EXEC` y, si se pasan parámetros, estos serán agregados a la consulta SQL 
        /// como parámetros nombrados (por ejemplo, `@Login = 'MAND'`).
        /// 
        /// Asegúrese de que la conexión a la base de datos esté correctamente configurada antes de usar este método.
        /// </remarks>
        /// <example>
        /// Ejemplo 1: Llamada a un procedimiento almacenado con un parámetro.
        /// <code>
        /// var parametres = new Dictionary&lt;string, string&gt; 
        /// {
        ///     { "@Login", "MAND" }
        /// };
        /// string nomProc = "BuscarUsuario";
        /// DataSet resultado = manteniment.ExecutaStoredProcedure(nomProc, parametres);
        /// </code>
        /// Esto generará una consulta SQL similar a:
        /// <code>
        /// EXEC BuscarUsuario @Login = 'MAND'  
        /// </code>
        /// 
        /// Ejemplo 2: Llamada a un procedimiento almacenado sin parámetros.
        /// <code>
        /// string nomProc = "ListarTodosLosClientes";
        /// DataSet resultado = manteniment.ExecutaStoredProcedure(nomProc, null);
        /// </code>
        /// Esto generará una consulta SQL similar a:
        /// <code>
        /// EXEC ListarTodosLosClientes  
        /// </code>
        /// </example>


        public DataSet ExecutaStoredProcedure(string nomProc, Dictionary<string, string> parametres)
        {
            DataSet ds = new DataSet();

            try
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = nomProc;

                if (parametres != null)
                {
                    foreach (var parametre in parametres)
                    { 
                        command.Parameters.Add(new SqlParameter(parametre.Key, parametre.Value));
                    }
                }

                connection.Open();
                SqlDataAdapter dta = new SqlDataAdapter(command);
                dta.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar el procedimiento almacenado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds = null;
            }
            finally
            {
                connection.Close();
            }

            return ds;
        }

    }
}
