using Entidades.finance;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sql
{
    public class GastoSQL : BaseSQL
    {
        public GastoSQL(Gasto gasto) : base()
        {
            this.Gasto = gasto;
        }

        public List<Gasto> Gastos { get; set; }
        public Gasto Gasto { get; set; }


        /// <summary>
        /// Guardo un nuevo gasto
        /// </summary>
        /// <exception cref="Exception"></exception>
        public override void Guardar()
        {

            if (Gasto is not null)
            {
                try
                {
                    string query = "INSERT INTO Gastos (IdTipoGasto, Valor, Fecha) VALUES (@IdTipoGasto, @Valor, @Fecha)";

                    using (SqlConnection sqlConnection = new SqlConnection(BaseSQL.ConnectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("IdTipoGasto", this.Gasto.IdTipoGasto);
                        sqlCommand.Parameters.AddWithValue("Valor", this.Gasto.Valor);
                        sqlCommand.Parameters.AddWithValue("Fecha", this.Gasto.Fecha);

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
                string query = "SELECT * FROM Gasto";

                using (SqlConnection sqlConnection = new SqlConnection(BaseSQL.ConnectionString))
                {

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        this.Gastos = new List<Gasto>(); //si tiene filas lo instancio

                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            int idTipoGasto = Convert.ToInt32(reader["IdTipoGasto"]);
                            double valor = Convert.ToDouble(reader["Valor"]);
                            DateTime fecha = Convert.ToDateTime(reader["Fecha"]);

                            //agrego cada gasto a la lista
                            this.Gastos.Add(new Gasto(id, idTipoGasto, valor, fecha));
                        }

                    }

                }

            }
            catch (Exception)
            {
                throw;
            }

        }

 

        public override void Eliminar()
        {
            if (this.Gasto is not null)
            {
                try
                {
                    string query = "DELETE FROM Gasto WHERE Id=@Id";

                    using (SqlConnection sqlConnection = new SqlConnection(BaseSQL.ConnectionString))
                    {

                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                        sqlCommand.Parameters.AddWithValue("Id", this.Gasto.Id);

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
