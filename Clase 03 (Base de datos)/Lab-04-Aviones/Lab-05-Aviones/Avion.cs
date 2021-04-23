using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Aviones
{
    public class Avion
    {
        public Avion(string nombre, int capacidad)
            {
            this.Nombre = nombre;
            this.Capacidad = capacidad;
            }

        public string Nombre { get; set; }
        public int Capacidad { get; set; }
    }
}
