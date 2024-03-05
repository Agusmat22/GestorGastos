using Entidades.finance;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.user;

namespace Entidades.sql
{
    public static class GastoSQL
    {
        private static string connectionString;


        static GastoSQL()
        {
            GastoSQL.connectionString = "Server = .; Database = GestorGastosDB; Trusted_Connection = True;";

        }





        /// <summary>
        /// Guardo un nuevo gasto
        /// </summary>
        /// <exception cref="Exception"></exception>
        public static int Guardar(Gasto gasto)
        {

            if (gasto is not null)
            {
                try
                {
                    string query = "INSERT INTO Gastos (IdTipoGasto, Valor, Fecha, IdUser) VALUES (@IdTipoGasto, @Valor, @Fecha, @IdUser); SELECT SCOPE_IDENTITY();";

                    using (SqlConnection sqlConnection = new SqlConnection(GastoSQL.connectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("IdTipoGasto", gasto.IdTipoGasto);
                        sqlCommand.Parameters.AddWithValue("Valor", gasto.Valor);
                        sqlCommand.Parameters.AddWithValue("Fecha", gasto.Fecha);
                        sqlCommand.Parameters.AddWithValue("IdUser", gasto.IdUser);

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
        

        public static List<Gasto> Obtener(User user, List<TipoGasto> tipoGasto)
        {
            try
            {
                string query = "SELECT * FROM Gastos WHERE IdUser=@IdUser";

                using (SqlConnection sqlConnection = new SqlConnection(GastoSQL.connectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("IdUser", user.Id);
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    List<Gasto> getGastos = new List<Gasto>();  

                    if (reader.HasRows)
                    {


                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            int idTipoGasto = Convert.ToInt32(reader["IdTipoGasto"]);
                            double valor = Convert.ToDouble(reader["Valor"]);
                            DateTime fecha = Convert.ToDateTime(reader["Fecha"]);
                            int idUser = Convert.ToInt32(reader["IdUser"]);


                            TipoGasto tipo = tipoGasto.Find((gasto) => gasto.Id == idTipoGasto);
                            

                            //agrego cada gasto a la lista
                            getGastos.Add(new Gasto(idTipoGasto, valor, fecha, idUser, tipo,id));
                        }

                        return getGastos;
                    }

                }

            }
            catch (Exception)
            {
                throw;
            }

            return null;

        }

 

        public static void Eliminar(Gasto gasto)
        {
            if (gasto is not null)
            {
                try
                {
                    string query = "DELETE FROM Gastos WHERE Id=@Id";

                    using (SqlConnection sqlConnection = new SqlConnection(GastoSQL.connectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Id", gasto.Id);

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

        
    }
}
