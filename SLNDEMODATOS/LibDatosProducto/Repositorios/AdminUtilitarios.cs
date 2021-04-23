using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using LibDatosProducto.BaseDatos;
using System.Data;
using LibDatosProducto.Models;

namespace LibDatosProducto.Repositorios
{

        public static class AdminUtilitarios
        {
            private static SqlCommand comando;
            private static SqlDataReader reader;
            public static List<string> traerColor()
            {

                string consulta = "Select distinct color from dbo.Producto";
                comando = new SqlCommand(consulta, AdminDB.conectarDB());
                SqlDataReader reader = comando.ExecuteReader();
                List<string> colores = new List<string>();
                while (reader.Read())
                {
                    colores.Add(reader[0].ToString());
                }
                reader.Close();
                AdminDB.conectarDB().Close();
                return colores;
            }
            public static List<Producto> PrecioMayor(decimal precioMayor)
            {
                string consulta = "SELECT Id,Nombre,Color,Precio FROM dbo.Producto where Precio>@Precio";
                SqlCommand cmd = new SqlCommand(consulta, AdminDB.conectarDB());
                cmd.Parameters.Add("@Precio", SqlDbType.Decimal).Value = precioMayor;
                SqlDataReader reader = cmd.ExecuteReader();
                List<Producto> productos = new List<Producto>();
                while (reader.Read())
                {
                    productos.Add(new Producto()
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Color = reader["Color"].ToString(),
                        Precio = Convert.ToDecimal(reader["Precio"])
                    });
                }
                reader.Close();
                AdminDB.conectarDB().Close();
                return productos;
            }

        }
 }



