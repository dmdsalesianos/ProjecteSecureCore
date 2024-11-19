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
        public MantenimentDades(string connectionString)
        {
            _connectionString = connectionString;
            connection = new SqlConnection(_connectionString);
        }

        /// <summary>
        /// Obtiene todos los registros de una tabla especificada en la base de datos.
        /// </summary>
        /// <param name="nomTaula">Nombre de la tabla a obtener.</param>
        /// <returns>Un <see cref="DataSet"/> que contiene los datos de la tabla.</returns>
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
                // Mostrar mensaje de error en un MessageBox
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
        /// <returns>Un <see cref="DataSet"/> que contiene los datos resultantes de la consulta.</returns>
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
                // Mostrar mensaje de error en un MessageBox
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
        /// Ejecuta una consulta SQL y devuelve los resultados en un <see cref="DataSet"/> con un nombre de tabla especificado.
        /// </summary>
        /// <param name="query">La consulta SQL a ejecutar.</param>
        /// <param name="nomDataTable">El nombre de la tabla en el <see cref="DataSet"/>.</param>
        /// <returns>Un <see cref="DataSet"/> que contiene los datos resultantes de la consulta.</returns>
        public DataSet PortarPerConsulta(string query, string nomDataTable)
        {
            ds = new DataSet();

            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(ds, nomDataTable);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en un MessageBox
                MessageBox.Show($"Error en la consulta para la tabla {nomDataTable}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// <returns>El número de filas afectadas por la actualización. Devuelve -1 si ocurre un error.</returns>
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
                // Mostrar mensaje de error en un MessageBox
                MessageBox.Show($"Error al actualizar la tabla {nomTaula}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result = -1; // Indicamos error
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
        /// <returns>El número de filas afectadas. Devuelve -1 si ocurre un error.</returns>
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
                // Mostrar mensaje de error en un MessageBox
                MessageBox.Show($"Error en la ejecución de la consulta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rowsAffected = -1; // Indicamos error
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
        public DataSet GeneraConsultaCerca(string nomTaula, Dictionary<string, object> criteris)
        {
            ds = new DataSet();

            try
            {
                List<string> condicions = new List<string>();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                foreach (var criteri in criteris)
                {
                    string paramName = $"@{criteri.Key}";
                    condicions.Add($"{criteri.Key} = {paramName}");
                    command.Parameters.AddWithValue(paramName, criteri.Value ?? DBNull.Value);
                }

                string query = $"SELECT * FROM {nomTaula} WHERE {string.Join(" AND ", condicions)}";
                command.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter(command);
                connection.Open();
                da.Fill(ds, nomTaula);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en un MessageBox
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
        public DataSet ExecutaStoredProcedure(string nomProc, Dictionary<string, object> parametres = null)
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
                // Mostrar mensaje de error en un MessageBox
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
        public void IniciarTransaccio()
        {
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en un MessageBox
                MessageBox.Show($"Error al iniciar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction = null;
            }
        }

        /// <summary>
        /// Confirma la transacción en curso y cierra la conexión.
        /// </summary>
        public void ConfirmarTransaccio()
        {
            try
            {
                transaction?.Commit();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en un MessageBox
                MessageBox.Show($"Error al confirmar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }


        /// <summary>
        /// Cancela la transacción en curso y cierra la conexión.
        /// </summary>
        public void CancelarTransaccio()
        {
            try
            {
                transaction?.Rollback();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error en un MessageBox
                MessageBox.Show($"Error al cancelar la transacción: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
        }

    }
}
