using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S219_CONSTRUCTORES
{
    class Estudiante
    {
        public string nombre;
        public string apellido;
        public float cum;
        public decimal cuotaMensual;
        public Estudiante()
        {
            cuotaMensual = 40.23m;
        }

        public Estudiante(string nombre,string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

    }
}
