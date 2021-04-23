using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // lo agrego
using WindowsFormsException.Models;


namespace WindowsFormsException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            try // proceso logico
            {
                int num1 = 5;
                int num2 = 0;
                int resultado = num1 / num2;

                MessageBox.Show(resultado.ToString());
            }
            catch (DivideByZeroException ex) // ESPECIALIZADA      : si da error, capturo la excepcion
            {
                MessageBox.Show(ex.Message);
                // o puedo personalizarlo:  Message.Show("Ocurrio un error.");
            }
            catch (Exception ex) // GENERICA - TIENE QUE SER EL ÚLTIMO!: capturo el error para cualquier otra exception que pueda ocurrir
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPruebaSQLServer_Click(object sender, EventArgs e)
        {
            SqlConnection conexion;
            string cadena = @"Data Source=.;Initial Catalog=pubs;Integrated Security=True";

            conexion = new SqlConnection(cadena);

            string consulta = "SELECT pub_id,pub_name,city,state,country FROM dbo.publishers";
            SqlCommand comando = new SqlCommand(consulta, conexion);

            try
            { 
                conexion.Open();

                SqlDataReader reader = comando.ExecuteReader();

                /* sigue con while - close reader- ext*/
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void btnExceptionSQLServer2_Click(object sender, EventArgs e)
        {
            string cadena = @"Data Source=.\sqlexpress;Initial Catalog=pubS;Integrated Security=True";

            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                
                string consulta = "SELECT pub_id, pub_name, city, state, country FROM dbo.publishers";

                SqlCommand comando = new SqlCommand(consulta, conexion);
                try
                {
                    conexion.Open();

                    SqlDataReader reader = comando.ExecuteReader();
                    /* sigue cód while - close reader - ext*/
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error");


                }
            } // close implicito de la base de datos por ejemplo--> conexion.Close()

        }

        private void btnCrearEvento_Click(object sender, EventArgs e)
        {
            try
            {
                Evento nuevo = new Evento("");
                MessageBox.Show(nuevo.Nombre);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
