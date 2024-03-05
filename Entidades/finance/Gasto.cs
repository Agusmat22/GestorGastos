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
        private int idUser;

        public Gasto()
        {

        }

        public Gasto(int idTipoGasto, double valor, DateTime fecha, int idUser, TipoGasto tipo):this()
        {
            this.idTipoGasto = idTipoGasto;
            this.valor = valor;
            this.fecha = fecha;
            this.idUser = idUser;
            this.Tipo = tipo;
        }

        public Gasto(int idTipoGasto , double valor, DateTime fecha, int idUser, TipoGasto tipo, int id): this(idTipoGasto,valor,fecha,idUser,tipo)
        {
            this.id = id;
        }

        


        public int Id { get => id; set => id = value; }
        public TipoGasto Tipo { get; set; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int IdTipoGasto { get => idTipoGasto; set => idTipoGasto = value; }
        public int IdUser { get => idUser; set => idUser = value; }
    }
}
