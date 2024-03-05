using Entidades.interfaces;
using Entidades.sql;
using Entidades.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.finance
{

    public class GestorGasto
    {

        private List<Gasto> gastos;

        private List<TipoGasto> tipoGasto;
        private User user;

        public GestorGasto() 
        { 
            this.gastos = new List<Gasto>();
            this.tipoGasto = new List<TipoGasto>();
        }

        public GestorGasto(List<Gasto> gastos, List<TipoGasto> tipo)
        {
            this.gastos = gastos;
            this.tipoGasto = tipo;
        }

        public List<Gasto> Gastos { get { return this.gastos; } set => gastos = value; }

        public List<TipoGasto> TipoGasto { get => tipoGasto; set => tipoGasto = value; }

        public User User { get => user; set => user = value; }

        public void AgregarGasto(Gasto newGasto)
        {
            int idGenerado = GastoSQL.Guardar(newGasto);

            newGasto.Id = idGenerado;
            this.gastos.Add(newGasto);
        }

        public void BorrarGasto(Gasto newGasto)
        {
            this.gastos.Remove(newGasto);
        }

        public void AgregarTipo(TipoGasto tipoGasto)
        {

            try
            {

                int id = TipoGastoSQL.Guardar(tipoGasto);
                tipoGasto.Id = id;
                this.TipoGasto.Add(tipoGasto);
            }
            catch (Exception) 
            {
                throw;
            }

        }

        public void ActualizarTipo(TipoGasto tipoGasto)
        {

            try
            {
                TipoGastoSQL.Actualizar(tipoGasto);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static double CalcularGastoTotal(List<Gasto> gastos)
        {
            double total = 0;

            foreach (Gasto item in gastos)
            {
                total += item.Valor;
            }

            return total;
        }

        /// <summary>
        /// Valida si el gasto generado y el porcentaje asignado no supera al limite por sueldo que tiene
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="porcentaje"></param>
        /// <returns></returns>
        public bool ReglaGasto(double gasto, int porcentaje)
        {
            return gasto < (this.User.Sueldo * porcentaje) / 100;  
        }



    }

}
