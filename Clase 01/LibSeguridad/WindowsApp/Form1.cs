using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibSeguridad; // agregar el using;
using BO; //agregar

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestSeguridad_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario() { Nombre = txtNombre.Text, Password = txtPassword.Text };
            //crear una instancia de la clase adminSeguridad
            AdminSeguridad objeto = new AdminSeguridad();

            bool resultado = objeto.autenticar(usuario); // el metodo recibe un usuario (linea 24)

            if (resultado)
            {
                MessageBox.Show("Bienvenido al sistema");
            }
            else
            {
                MessageBox.Show("No se encuentra el usuario. Revise los datos ingresados");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
