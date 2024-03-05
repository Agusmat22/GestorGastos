using Entidades.finance;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.user;
using Entidades.interfaces;

namespace Entidades.sql
{
    public static class TipoGastoSQL 
    {

        private static string connectionString;


        static TipoGastoSQL()
        {
            TipoGastoSQL.connectionString = "Server = .; Database = GestorGastosDB; Trusted_Connection = True;";

        }


        public static void Eliminar(TipoGasto tipoGasto)
        {
            if (tipoGasto is not null)
            {
                try
                {
                    string query = "DELETE FROM TipoGasto WHERE Id=@Id";

                    using (SqlConnection sqlConnection = new SqlConnection(TipoGastoSQL.connectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Id", tipoGasto.Id);

                        sqlConnection.Open();

                        sqlCommand.ExecuteNonQuery();


                    }

                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                throw new Exception("Error, debe inyectar un nuevo Gasto para poder guardar");
            }
        }

        public static int Guardar(TipoGasto tipoGasto)
        {
            if (tipoGasto is not null)
            {
                try
                {
                    string query = "INSERT INTO TipoGasto ( Nombre, Tipo) VALUES (@Nombre, @Tipo); SELECT SCOPE_IDENTITY();";

                    using (SqlConnection sqlConnection = new SqlConnection(TipoGastoSQL.connectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Nombre", tipoGasto.Nombre);
                        sqlCommand.Parameters.AddWithValue("Tipo", tipoGasto.Tipo.ToString());

                        sqlConnection.Open();

                        int insertedId = Convert.ToInt32(sqlCommand.ExecuteScalar());

                        return insertedId;


                    }

                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                throw new Exception("Error, debe inyectar un nuevo Gasto para poder guardar");
            }
        }

        public static List<TipoGasto> Obtener()
        {
            try
            {
                string query = "SELECT * FROM TipoGasto";

                using (SqlConnection sqlConnection = new SqlConnection(TipoGastoSQL.connectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    List<TipoGasto> tipoGastos = new List<TipoGasto>();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string nombre = reader["Nombre"].ToString();

                            EGasto tipoGasto;

                            if (Enum.TryParse<EGasto>(reader["Tipo"].ToString(), out tipoGasto))
                            {

                                //agrego cada gasto a la lista
                                tipoGastos.Add(new TipoGasto(nombre, tipoGasto, id));
                            }

                            
                        }

                        return tipoGastos;

                    }


                }

            }
            catch (Exception)
            {
                throw;
            }

            return null;
        }

        public static void Actualizar(TipoGasto tipoGasto)
        {
            if (tipoGasto is not null)
            {
                try
                {
                    string query = "UPDATE TipoGasto " +
                                   "SET Nombre=@Nombre, Tipo=@Tipo WHERE Id=@Id";

                    using (SqlConnection sqlConnection = new SqlConnection(TipoGastoSQL.connectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Nombre", tipoGasto.Nombre);
                        sqlCommand.Parameters.AddWithValue("Tipo", tipoGasto.Tipo.ToString());
                        sqlCommand.Parameters.AddWithValue("Id", tipoGasto.Id);

                        sqlConnection.Open();

                        sqlCommand.ExecuteNonQuery();

                    }

                }
                catch (Exception)
                {
                    throw;
                }

            }
            else
            {
                throw new Exception("Error, debe inyectar un Tipo de Gasto para poder actualizarlo");
            }
        }
    }

    
}
