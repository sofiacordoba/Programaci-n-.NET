using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsDemoPOO.Models; // agregar

namespace WindowsDemoPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCtaCte_Click(object sender, EventArgs e)
        {
            // CtaCte ctacte = new CtaCte() { Balance = 10, Nombre = "A" };

            //CtaCte ctacte2 = new CtaCte();
            //ctacte2.Nombre = "     btest     ";
            //ctacte2.Balance = 12;

            CtaCte ctacte2 = new CtaCte("Test", 10); // USO CONSTRUCTOR CON PARAMETRO

            MessageBox.Show(ctacte2.Nombre);

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            persona.Apellido = "Perez"; //objeto persona, Apellido atributo
            persona.Nombre = "Juan";
            persona.FechaNacimiento = new DateTime(2000, 6, 20);

            MessageBox.Show("La edad es: " + persona.Edad.ToString());
            // ToString para que todo sea cadena

        }
    }
}
