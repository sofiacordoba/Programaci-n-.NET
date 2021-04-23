using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO.Models
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public DatosContacto DatosContacto { get; set; }
        public Empresa(int id, string nombre, string cuit, DatosContacto datosContacto)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Cuit = cuit;
            this.DatosContacto = datosContacto;
        }

    }
}
