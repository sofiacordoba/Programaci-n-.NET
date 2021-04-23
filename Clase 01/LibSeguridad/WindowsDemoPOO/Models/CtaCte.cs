using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDemoPOO.Models
{
    public class CtaCte
    {
        #region propiedades completas
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private string nombre; 

        public  string Nombre
        {
            get { return nombre.ToUpper(); }
            set { nombre = value.Trim(); }
        }


        #endregion

        #region constructores

        public CtaCte(string Nombre, int Balance)  //CONSTRUCTOR CON PARAMETRO
        {
            this.Balance = Balance;
            this.Nombre = Nombre;
        }

        public CtaCte() { } // CONSTRUCTOR PREDETERMINADO
        #endregion
    }
}
