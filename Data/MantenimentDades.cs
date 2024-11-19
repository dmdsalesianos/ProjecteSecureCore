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
            int result;

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(querySelect, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                result = da.Update(ds.Tables[nomTaula]);
            }
            catch (Exception ex)
            {
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
        /// <param name="criteris">Diccionario de criterios de búsqueda, donde la clave es el nombre de la columna y el valor es el valor a buscar.</param>
        /// <returns>Un <see cref="DataSet"/> con los resultados de la búsqueda.</returns>
        /// <remarks>
        /// Este método genera dinámicamente una consulta SQL para buscar registros en una tabla según múltiples criterios especificados.
        /// Los criterios de búsqueda son proporcionados como un diccionario de claves y valores.
        /// </remarks>
        /// <example>
        /// <code>
        /// var criteris = new Dictionary&lt;string, object&gt; { { "Edad", 30 }, { "Nombre", "Juan" } };
        /// DataSet result = db.GeneraConsultaCerca("Clientes", criteris);
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
        /// Ejecuta un procedimiento almacenado con parámetros opcionales y devuelve los resultados en un <see cref="DataSet"/>.
        /// </summary>
        /// <param name="nomProc">Nombre del procedimiento almacenado.</param>
        /// <param name="parametres">Diccionario de parámetros, donde la clave es el nombre del parámetro y el valor es el valor del parámetro.</param>
        /// <returns>Un <see cref="DataSet"/> con los resultados del procedimiento almacenado.</returns>
        /// <remarks>
        /// Este método ejecuta un procedimiento almacenado en la base de datos, con la posibilidad de pasar parámetros opcionales.
        /// Los parámetros se agregan al comando antes de ejecutar el procedimiento.
        /// </remarks>
        /// <example>
        /// <code>
        /// var parametros = new Dictionary&lt;string, object&gt; { { "idCliente", 5 } };
        /// DataSet result = db.ExecutaStoredProcedure("ObtenerClientePorId", parametros);
        /// </code>
        /// </example>
        public DataSet ExecutaStoredProcedure(string nomProc, Dictionary<string, object> parametres)
        {
            ds = new DataSet();

            try
            {
                SqlCommand command = new SqlCommand(nomProc, connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (parametres != null)
                {
                    foreach (var parametre in parametres)
                    {
                        command.Parameters.AddWithValue($"@{parametre.Key}", parametre.Value ?? DBNull.Value);
                    }
                }

                SqlDataAdapter da = new SqlDataAdapter(command);
                connection.Open();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ejecutar el procedimiento almacenado {nomProc}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ds = null;
            }
            finally
            {
                connection.Close();
            }

            return ds;
        }

        /// <summary>
        /// Inicia una transacción en la conexión de la base de datos.
        /// </summary>
        /// <remarks>
        /// Este método abre una conexión a la base de datos y comienza una transacción, que puede ser confirmada o cancelada posteriormente.
        /// </remarks>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// db.IniciarTransaccio();
        /// </code>
        /// </example>
        public void IniciarTransaccio()
        {
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction = null;
            }
        }

        /// <summary>
        /// Confirma la transacción en curso y cierra la conexión.
        /// </summary>
        /// <remarks>
        /// Este método confirma todos los cambios realizados en la transacción y cierra la conexión a la base de datos.
        /// </remarks>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// db.ConfirmarTransaccio();
        /// </code>
        /// </example>
        public void ConfirmarTransaccio()
        {
            try
            {
                transaction?.Commit();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al confirmar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

        /// <summary>
        /// Cancela la transacción en curso y cierra la conexión.
        /// </summary>
        /// <remarks>
        /// Este método revierte todos los cambios realizados durante la transacción y cierra la conexión a la base de datos.
        /// </remarks>
        /// <example>
        /// Ejemplo de uso:
        /// <code>
        /// db.CancelarTransaccio();
        /// </code>
        /// </example>

        public void CancelarTransaccio()
        {
            try
            {
                transaction?.Rollback();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cancelar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }


    }
}
