using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppRelacionObjetos.Models
{
    public class Curso
    {
        public List<Alumno> Alumnos { get; set; }
        public List<Clase> Clases { get; set; }
        public Instructor Instructor { get; set; }
        public Materia Materia { get; set; }
    }
}
