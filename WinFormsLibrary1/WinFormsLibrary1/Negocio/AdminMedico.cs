using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdminMedico
    {
        public static List<Medico> Listar()
        {
            //TODO Falta escribir el método Listar()
            return null;
        }
        public static List<Medico> Listar(string especialidad)
        {
            //TODO Falta escribir el método Listar(especialidad)
            return null;
        }

        public static List<Medico> Listar(string especialidad, string ciudad)
        {
            //TODO Falta escribir el método Listar(especialidad, ciudad)
            return null;
        }

        public static Medico TraerMedico(int id)
        {
            //TODO Falta escribir el método TraerMedico(int id) 
            return null;
        }

        public static bool Agregar(Medico medico)
        {
            //TODO Falta escribir el método Agregar(Medico medico)
            return true;
        }
        public static bool Eliminar(int idMedico)
        {
            //TODO Falta escribir el método Eliminar(int idMedico)
            return true;
        }

        public static bool Modificar(Medico medico)
        {
            //TODO Falta escribir el método Modificar(Medico medico)
            return true;
        }
    }
}
