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
    public class TipoGastoSQL : BaseSQL
    {
        public TipoGastoSQL(): base()
        {

        }

        public TipoGastoSQL(TipoGasto tipoGasto) : this()
        {
            this.TipoGasto = tipoGasto;
        }

        public List<TipoGasto> TipoGastos { get; set; }
        public TipoGasto TipoGasto { get; set; }

        public override void Eliminar()
        {
            if (this.TipoGasto is not null)
            {
                try
                {
                    string query = "DELETE FROM TipoGasto WHERE Id=@Id";

                    using (SqlConnection sqlConnection = new SqlConnection(BaseSQL.ConnectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Id", this.TipoGasto.Id);

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
            if (this.TipoGasto is not null)
            {
                try
                {
                    string query = "INSERT INTO TipoGasto ( Nombre, Tipo) VALUES (@Nombre, @Tipo)";

                    using (SqlConnection sqlConnection = new SqlConnection(BaseSQL.ConnectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Nombre", this.TipoGasto.Nombre);
                        sqlCommand.Parameters.AddWithValue("Tipo", this.TipoGasto.Tipo.ToString());

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
                string query = "SELECT * FROM TipoGasto";

                using (SqlConnection sqlConnection = new SqlConnection(BaseSQL.ConnectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        this.TipoGastos = new List<TipoGasto>(); //si tiene filas lo instancio

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string nombre = reader["Nombre"].ToString();

                            EGasto tipoGasto;

                            if (Enum.TryParse<EGasto>(reader["Tipo"].ToString(), out tipoGasto))
                            {

                                //agrego cada gasto a la lista
                                this.TipoGastos.Add(new TipoGasto(nombre, id, tipoGasto));
                            }

                            
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
