using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_05_Aviones
{
    public class Vuelo
    {
        public string Destino { get; set; }
        public DateTime Duracion { get; set; }
        public DateTime FechaSalida { get; set; }
        public Tripulacion Tripulacion { get; set; }
        public List<Pasaje> Pasajes { get; set; }

        public Vuelo(string destino, DateTime duracion, DateTime fechaSalida, Tripulacion tripulacion, List<Pasaje> pasajes)
        {
            Destino = destino;
            Duracion = duracion;
            FechaSalida = fechaSalida;

        }
    }
}