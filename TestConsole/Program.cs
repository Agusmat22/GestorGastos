using Entidades.finance;
using Entidades.interfaces;
using Entidades.sql;
using Entidades.user;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             User user = new User(1,"Agustin",50,30,20);
             UserSQL userSQL = new UserSQL(user);

             userSQL.Guardar();*/

            TipoGastoSQL tipoGasto = new TipoGastoSQL();

            tipoGasto.Obtener();

            foreach (TipoGasto item in tipoGasto.TipoGastos)
            {
                Console.WriteLine(item);
            }



        }
    }
}
