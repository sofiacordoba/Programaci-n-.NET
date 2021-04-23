using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public abstract class Persona
    {
        public Persona(int id, string nombre, string apellido, string dni, DatosContacto datosContacto)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
            this.DatosContacto = datosContacto;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public DatosContacto DatosContacto { get; set; }

    }
}
