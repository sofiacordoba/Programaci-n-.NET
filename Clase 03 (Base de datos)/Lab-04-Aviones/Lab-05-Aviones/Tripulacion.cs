using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Aviones
{
    public class Tripulacion
    {
        public Piloto Piloto { get; set; }
        public Copiloto Copiloto { get; set; }
        public List<Azafata> Azafatas { get; set; }

        public Tripulacion(Piloto piloto, Copiloto copiloto, List<Azafata> azafatas)
        {
            Piloto = piloto;
            Copiloto = copiloto;
            Azafatas = azafatas;
        }
    }
}
