using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoPOO.Models
{
    public class Persona
    {

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        //solo escritura (no tiene get, solo SET)
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento 
        {
            set { fechaNacimiento = value; }
        }


        //solo lectura (no tiene set, solo GET para retornar un valor)
        public int Edad
        {
            get {
                return DateTime.Now.Year - fechaNacimiento.Year;
            }
        }
    }
}
