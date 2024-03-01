﻿using Entidades.finance;
using Entidades.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.user
{
    //El usuario tendra registrado su porcentaje de ahorro con su nombre para ser identificado
    public class User : IReglaAhorro
    {
        private int id;
        private string nombre;
        private int r50;
        private int r30;
        private int r20;

        public User(int id, string nombre, int r50, int r30, int r20) 
        { 
            this.id = id;
            this.nombre = nombre;   
            this.r50 = r50;
            this.r30 = r30;
            this.r20 = r20;
        }


        public string Nombre { get => nombre; set => nombre = value; }
        public int R50 { get => r50; set => r50 = value; }
        public int R30 { get => r30; set => r30 = value; }
        public int R20 { get => r20; set => r20 = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"{this.Nombre}";
        }
    }
}
