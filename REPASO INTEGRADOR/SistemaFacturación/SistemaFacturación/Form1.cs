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
using Entidades.Models;
using Negocio.Admin; // agregar

namespace SistemaFacturación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            //configurar el objeto de conexion
            string cadena = "Data Source=.;Initial Catalog=DBFACTURACION;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);

            //preparando la consulta SQL
            string consulta = "SELECT [Id],[Nombre],[Apellido],[FechaNacimiento] FROM [dbo].[Cliente]";

            //comando
            SqlCommand comando = new SqlCommand(consulta, conexion);

            //reader
            conexion.Open();  // con esto administramos la conexión
            SqlDataReader reader = comando.ExecuteReader();

            //leer los datos
            while (reader.Read())
            {
                lstCliente.Items.Add(reader[0]+ " " + reader["Nombre"]);
            }
            reader.Close();
            conexion.Close();
        }

        private void btnTraerTodosClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes(); // llamo al metodo(*)
        }

        private void MostrarClientes() // creo un metodo para llamarlo las veces que quiera
        {
            gridCliente.DataSource = AdminCliente.Listar(); //(*)para hacer esto
        }
        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente()
            {
                Id = 13,
                Nombre = "Lucila",
                Apellido = "Juarez",
                FechaNacimiento = new DateTime(1997,02,05)
            };
            int filas = AdminCliente.Agregar(nuevo);

            gridCliente.DataSource = AdminCliente.Listar();
        }
    }
}
