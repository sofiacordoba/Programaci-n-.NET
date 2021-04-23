using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class Vendedor : Persona
    {
        public decimal Comision { get; set; }

        public Vendedor(int id, string nombre, string apellido, string dni, DatosContacto datosContacto, decimal comision)
            : base(id, nombre, apellido, dni, datosContacto)
        {

            Comision = comision;

        }

    }
}
