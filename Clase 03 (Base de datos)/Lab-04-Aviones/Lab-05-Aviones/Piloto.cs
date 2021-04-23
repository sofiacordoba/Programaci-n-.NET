using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Aviones
{
    public class Piloto : Persona
    {
        public Piloto(string nombre, string apellido, int dni, DateTime fechaNacimiento)
        : base(nombre, apellido, dni, fechaNacimiento) { }
    }
}
