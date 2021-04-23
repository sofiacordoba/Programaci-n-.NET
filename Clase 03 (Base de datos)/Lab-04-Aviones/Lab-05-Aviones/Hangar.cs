using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Aviones
{
    public class Hangar
    {
        public Hangar(List<Avion> aviones)
        {
            this.Aviones = aviones;
        }
        List<Avion> Aviones { get; set; }
    }

}
