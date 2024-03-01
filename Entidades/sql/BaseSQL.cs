using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.sql
{
    public abstract class BaseSQL
    {
        private static string connectionString;


        static BaseSQL()
        {
            BaseSQL.connectionString = "Server = .; Database = GestorGastosDB; Trusted_Connection = True;";
        }


        public static string ConnectionString { get => BaseSQL.connectionString; }


        public abstract void Guardar();


        public abstract void Obtener();


        public abstract void Eliminar();
        
    }
}
