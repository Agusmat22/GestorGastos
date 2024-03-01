using Entidades.interfaces;
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

        //A medida que tengamos gastos, vamos a ir registrandolos y quedara en en esta interfaz
        //asi sera mas facil registrarlos
        private List<ITipoGasto> tipos;

        public GestorGasto() 
        { 
            this.gastos = new List<Gasto>();
            this.tipos = new List<ITipoGasto>();
        }

        public GestorGasto(List<Gasto> gastos, List<ITipoGasto> tipo)
        {
            this.gastos = gastos;
            this.tipos = tipo;
        }

        public List<Gasto> Gastos { get { return this.gastos; } }

        public void Agregar(Gasto newGasto)
        {
            this.gastos.Add(newGasto);
        }

        public void Borrar(Gasto newGasto)
        {
            this.gastos.Remove(newGasto);
        }


    }

}
