using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Usuario
    {
        #region Zona de constructores
        public Usuario() { } //CONSTRUCTOR POR DEFECTO. el constructor lleva el mismo nombre que la clase, y sirve para inicializar

        public Usuario(string nombre, string password, string Email) //CONSTRUCTOR CON SOBRECARGA
        {
            Nombre = nombre;
            this.Password = password;  //this.ATRIBUTO hace referencia a donde estamos parados
            this.Email = Email;
        }
        #endregion

        #region Zona de propiedades autoimplementadas
        public string Nombre { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }
        #endregion
    }
}
