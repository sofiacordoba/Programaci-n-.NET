using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class DatosContacto
    {
        public DatosContacto(string domicilio, string email, string telefono)
        {
            this.Domicilio = domicilio;
            this.Email = email;
            this.Telefono = telefono;
        }
        public string Domicilio { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public override string ToString()
        {
            return $"{Domicilio}, {Email}, {Telefono}";
        }
    }
}
