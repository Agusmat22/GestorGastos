using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.finance
{
    public enum EGasto
    {
        Servicios,
        Necesidad,
        Imprevisto,
        Ocio,
        Ahorro

    }

    //discrimina el nombre del gasto realizado y su tipo

    public class TipoGasto
    {
        private int id;
        private string nombre;
        private EGasto tipo;


        public TipoGasto()
        {

        }

        public TipoGasto(string nombre ,EGasto tipo): this()
        {
            this.nombre = nombre;
            this.tipo = tipo;   
        }

        public TipoGasto(string nombre, EGasto tipo, int id): this(nombre,tipo)
        {
            this.id = id;

        }

        public string Nombre { get => nombre; set => nombre = value; }
        public EGasto Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString() 
        {
            return $"{this.nombre}";
        }
    }
}
