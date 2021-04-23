using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BO.Models;
using System.Data;

namespace Negocio
{
    public static class AdminVendedor
    {
        public static List<Vendedor> TraerTodos()
        {
            List<Vendedor> lista = new List<Vendedor>();

            string consulta = "SELECT [Id],[Nombre],[Apellido],[DNI],[Domicilio],[Telefono],[Email],[Comision] FROM [dbo].[Vendedor]";

            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())  // debo llenar una lista
            {
                lista.Add(
                    new Vendedor(

                       Convert.ToInt32(reader["ID"]),
                        reader["Nombre"].ToString(),
                        reader["Apellido"].ToString(),
                        reader["DNI"].ToString(),
                        new DatosContacto(reader["Domicilio"].ToString(), reader["Email"].ToString(), reader["Telefono"].ToString()),
                        Convert.ToDecimal(reader["Comision"]))
                    );
                
            }
            reader.Close();
            AdminDB.conectarDB().Close();
            return lista;
        }
        public static int Agregar(Vendedor vendedor)
    {
        string consulta = @"INSERT INTO [dbo].[Vendedor] ([Nombre],[Apellido],[DNI],[Domicilio],[Telefono],[Email],[Comision]) VALUES (@Nombre,@Apellido,@DNI,@Domicilio,@Telefono,@Email,@Comision)";
        
        var conexion = AdminDB.conectarDB();

        SqlCommand comando = new SqlCommand(consulta, conexion);

        comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = vendedor.Nombre;
        comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = vendedor.Apellido;
        comando.Parameters.Add("@DNI", SqlDbType.Char, 11).Value = vendedor.DNI;
        comando.Parameters.Add("@Domicilio", SqlDbType.VarChar, 50).Value = vendedor.DatosContacto.Domicilio;
        comando.Parameters.Add("@Telefono", SqlDbType.VarChar, 50).Value = vendedor.DatosContacto.Telefono;
        comando.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = vendedor.DatosContacto.Email;
        comando.Parameters.Add("@Comision", SqlDbType.Decimal, 18).Value = vendedor.Comision;

        int filasAfectadas = comando.ExecuteNonQuery();
        conexion.Close();
        return filasAfectadas;

    }
}
}
