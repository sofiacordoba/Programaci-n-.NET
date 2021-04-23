using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsException.Models
{
    public class Evento
    {
        public Evento(string nombre)
        {

            if (nombre.Trim().Length < 1 || nombre.Trim().Length > 50)
            {
                throw new Exception("Es campo obligatorio, no puede superar 50 caracteres");
            }

            Nombre = nombre;
        }
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (value.Trim().Length < 1 || value.Trim().Length > 50)
                {
                    throw new Exception("Es campo obligatorio, no puede superar 50 caracteres");
                }

                nombre = value.Trim();
            }
        }
    }
}
}
