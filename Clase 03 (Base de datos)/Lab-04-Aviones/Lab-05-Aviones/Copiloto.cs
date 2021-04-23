using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Aviones
{
    public class Copiloto : Persona
    {
        public Copiloto(string nombre, string apellido, int dni, DateTime fechaNacimiento)
         : base(nombre, apellido, dni, fechaNacimiento) { }
    }
}
