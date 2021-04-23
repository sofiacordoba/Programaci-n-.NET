using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Aviones
{
    public class Pasajero : Persona
    {
        public List<Pasaje> Pasajes { get; set; }

        public Pasajero(string nombre, string apellido, int dni, DateTime fechaNacimiento, List<Pasaje> pasajes) 
        : base(nombre, apellido, dni, fechaNacimiento)
        {
            Pasajes = pasajes;
        }
    }
}
