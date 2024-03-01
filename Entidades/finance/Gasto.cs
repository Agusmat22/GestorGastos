using Entidades.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.finance
{

    
    //Gestiona el gasto registrado por el usuario con toda su informacion

    public class Gasto
    {
        private int id;
        private int idTipoGasto;
        private double valor;
        private DateTime fecha;

        public Gasto(int id, int idTipoGasto , double valor, DateTime fecha)
        {
            this.id = id;
            this.idTipoGasto = idTipoGasto;
            this.valor = valor;
            this.fecha = fecha;
        }


        public int Id { get => id; set => id = value; }
        public TipoGasto Tipo { get; set; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdTipoGasto { get => idTipoGasto; set => idTipoGasto = value; }
    }
}
