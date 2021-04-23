using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Windowsadonet.BaseDatos
{
    internal static class AdminDB
    {

        internal static SqlConnection conexion()
         {
                //configurar el objeto de conexion
                string cadena = @"Data Source=.;Initial Catalog=pubs;Integrated Security=True";
                 SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();

                return conexion;

        }
    }
}
