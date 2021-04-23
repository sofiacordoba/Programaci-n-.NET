using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Aviones
{
    public class AvionComercial : Avion
    {
        public List<Vuelo> Vuelos { get; set; }

        public AvionComercial(string nombre, int capacidad, List<Vuelo> vuelos) : base(nombre, capacidad)
        {
            this.Vuelos = vuelos;
        }

    }
}
