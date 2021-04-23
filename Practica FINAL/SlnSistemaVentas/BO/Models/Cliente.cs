using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class Cliente : Persona
    {
        public Cliente(int id, string nombre, string apellido, string dni, DatosContacto datosContacto)
            :base(id,nombre,apellido,dni,datosContacto)
        {
           //
        }
    }
}
