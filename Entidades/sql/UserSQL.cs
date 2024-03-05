using Entidades.finance;
using Entidades.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades.sql
{
    public static class UserSQL 
    {


        private static string connectionString;


        static UserSQL()
        {
            UserSQL.connectionString = "Server = .; Database = GestorGastosDB; Trusted_Connection = True;";

        }




        public static void Eliminar(User user)
        {
            if (user is not null)
            {
                try
                {
                    string query = "DELETE FROM Usuario WHERE Id=@Id";

                    using (SqlConnection sqlConnection = new SqlConnection(UserSQL.connectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Id", user.Id);

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

        public static int Guardar(User user)
        {
            if (user is not null)
            {
                try
                {
                    string query = "INSERT INTO Usuario (Nombre, R50, R30, R20, Sueldo) VALUES (@Nombre, @R50, @R30, @R20, @Sueldo); SELECT SCOPE_IDENTITY();";

                    using (SqlConnection sqlConnection = new SqlConnection(UserSQL.connectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Nombre", user.Nombre);
                        sqlCommand.Parameters.AddWithValue("R50", user.R50);
                        sqlCommand.Parameters.AddWithValue("R30", user.R30);
                        sqlCommand.Parameters.AddWithValue("R20", user.R20);
                        sqlCommand.Parameters.AddWithValue("Sueldo", user.Sueldo);

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

        public static List<User> Obtener()
        {
            try
            {
                string query = "SELECT * FROM Usuario";

                using (SqlConnection sqlConnection = new SqlConnection(UserSQL.connectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    List<User> users = new List<User>();

                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string nombre = reader["Nombre"].ToString();
                            int r50 = Convert.ToInt32(reader["R50"]);
                            int r30 = Convert.ToInt32(reader["R30"]);
                            int r20 = Convert.ToInt32(reader["R20"]);
                            double sueldo = Convert.ToDouble(reader["Sueldo"]);



                            //agrego cada gasto a la lista
                            users.Add(new User(id,nombre,r50,r30,r20, sueldo));
                        }

                        return users;
                    }


                }

            }
            catch (Exception)
            {
                throw;
            }

            return null;
        }
    }
}
