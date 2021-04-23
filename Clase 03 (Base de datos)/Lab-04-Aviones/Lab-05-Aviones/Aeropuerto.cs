using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Aviones
{
    public class Aeropuerto
    {
        public Aeropuerto(List<Hangar> hangares)
        {
            this.Hangares = hangares;
        }
        List<Hangar> Hangares { get; set; }
    }

}
