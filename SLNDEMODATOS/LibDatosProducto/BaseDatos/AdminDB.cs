using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibDatosProducto.BaseDatos
{
    internal static class AdminDB
    {
        internal static SqlConnection conectarDB()
        {
            string cadena = Properties.Settings.Default.KeyDB;
            SqlConnection conexion = new SqlConnection(cadena);

            conexion.Open();
            return conexion;
        }
    }
}
