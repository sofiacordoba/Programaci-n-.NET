using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BO.Models;
using Negocio;

namespace AppWindowsVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnTraerTodosLosVendedores_Click(object sender, EventArgs e)
        {
            TraerVendedores();
        }
        private void TraerVendedores()
        {
            gridVendedor.DataSource = AdminVendedor.TraerTodos().ToList();
        }


        private void btnAgregarVendedor_Click(object sender, EventArgs e)
        {
            AdminVendedor.Agregar(
                new Vendedor(
                   15,
                  "Maria",
                  "Perez",
                  "39586155",
                   new DatosContacto("Chivilcoy", "sofia123@hotmail.com", "4105555"),
                   1
            ));

            TraerVendedores();
        }

        private void gridVendedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
