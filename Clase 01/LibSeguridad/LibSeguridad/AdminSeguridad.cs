using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO; //agregar;

namespace LibSeguridad
{
    public class AdminSeguridad
    {

        /// <summary>
        /// Funcion para validar las credenciales del usuario
        /// </summary>
        /// <param name="nombre"></param> se espera el nombre del usuario de tipo cadena
        /// <param name="password"></param> se espera la password. Debe tener 4 digitos
        /// <returns></returns> retorna true si el usuario existe en la base de datos
        
        public bool autenticar(Usuario usuario) // recibe por parametro un usuario
        {
            //TODO esto es una prueba, luego lo configuramos con la capa de datos
            if (usuario.Nombre == "juan" && usuario.Password == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int registrar(Usuario usuario)
        {

            //TODO falta escribir la implementacion del código
            return 0;
        }

    }
}
