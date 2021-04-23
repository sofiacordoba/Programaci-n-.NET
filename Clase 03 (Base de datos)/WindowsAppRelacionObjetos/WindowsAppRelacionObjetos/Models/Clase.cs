using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppRelacionObjetos.Models
{
    public class Clase
    {
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }

        public Aula Aula { get; set; }
    }
}
