using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windowsadonet.Admin;
using Windowsadonet.Models;





namespace Windowsadonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            //configurar el objeto de conexion
            string cadena = @"Data Source=.;Initial Catalog=pubs;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);

            //preparando la consulta SQL
            string consulta = "SELECT [au_id],[au_lname],[au_fname],[phone],[address],[city],[state],[zip],[contract] FROM [dbo].[authors]";

            //comando
            SqlCommand comando = new SqlCommand(consulta, conexion);

            //reader
            conexion.Open(); //administrar la conexión
            SqlDataReader reader = comando.ExecuteReader();

            //leer los datos
            while (reader.Read())
            {
                lstAutor.Items.Add(reader[1]+ "" + reader["au_fname"]);

            }
            reader.Close();
            conexion.Close();
        }


        private void btnEditor_Click(object sender, EventArgs e)
        {
            //configurar el objeto de conexion
            string cadena = @"Data Source=.;Initial Catalog=pubs;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena);

            //preparando la consulta SQL
            string consulta = "SELECT [pub_id],[pub_name],[city],[state],[country] FROM [dbo].[publishers]";

            //comando 
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open(); //administrar la conexión
            SqlDataReader reader = comando.ExecuteReader();

            //reader

                            //leer los datos
            while (reader.Read())
            {
                lstEditor.Items.Add(reader["pub_name"]);
            }
            reader.Close();
            conexion.Close();
        }

        private void btnTraerTodosPublisher_Click(object sender, EventArgs e)
        {
            MostrarPublishers();
        }

        private void MostrarPublishers()
        {
            gridPublisher.DataSource = AdminPublisher.Lista();
        }

        private void btnInsertarEditor_Click(object sender, EventArgs e)
        {
            Publisher nuevo = new Publisher()
            {
                Pub_id = "3333",
                City = "La Plata",
                Country = "Argentina",
                Pub_name = "Mi Editor",
                State = "AR"
            };

            int filas = AdminPublisher.Agregar(nuevo);

            gridPublisher.DataSource = AdminPublisher.Lista();
        }

        private void btnInsertarAutor_Click(object sender, EventArgs e)
        {
            Author nuevo = new Author()
        }
    }
}
