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
    public class UserSQL : BaseSQL
    {

        public UserSQL(User user): base()
        { 
            this.User = user;

        }

        public User User { get; set; }
        public List<User> Users { get; set; }



        public override void Eliminar()
        {
            if (this.User is not null)
            {
                try
                {
                    string query = "DELETE FROM Usuario WHERE Id=@Id";

                    using (SqlConnection sqlConnection = new SqlConnection(BaseSQL.ConnectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Id", this.User.Id);

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

        public override void Guardar()
        {
            if (this.User is not null)
            {
                try
                {
                    string query = "INSERT INTO Usuario (Nombre, R50, R30, R20 ) VALUES (@Nombre, @R50, @R30, @R20)";

                    using (SqlConnection sqlConnection = new SqlConnection(BaseSQL.ConnectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Nombre", this.User.Nombre);
                        sqlCommand.Parameters.AddWithValue("R50", this.User.R50);
                        sqlCommand.Parameters.AddWithValue("R30", this.User.R30);
                        sqlCommand.Parameters.AddWithValue("R20", this.User.R20);

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

        public override void Obtener()
        {
            try
            {
                string query = "SELECT * FROM Usuario";

                using (SqlConnection sqlConnection = new SqlConnection(BaseSQL.ConnectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        this.Users = new List<User>(); //si tiene filas lo instancio

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string nombre = reader["Nombre"].ToString();
                            int r50 = Convert.ToInt32(reader["R50"]);
                            int r30 = Convert.ToInt32(reader["R30"]);
                            int r20 = Convert.ToInt32(reader["R20"]);



                            //agrego cada gasto a la lista
                            this.Users.Add(new User(id,nombre,r50,r30,r20));
                        }

                    }


                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
