using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDatosProducto.Models;
using System.Data.SqlClient;
using LibDatosProducto.BaseDatos;
using System.Data;

namespace LibDatosProducto.Repositorios
{
    public static class AdminProducto
    {
        private static SqlCommand comando;
        private static SqlDataReader reader;
        public static int modificar(Producto producto)
        {
            string consulta = "UPDATE [dbo].[Producto] SET Nombre = @Nombre,Color = @Color," +
                "Precio = @Precio WHERE Id= @Id";

            comando = new SqlCommand(consulta, AdminDB.conectarDB());

            
            comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = producto.Nombre;
            comando.Parameters.Add("@Color", System.Data.SqlDbType.VarChar, 50).Value = producto.Color;
            comando.Parameters.Add("@Precio", System.Data.SqlDbType.Money).Value = producto.Precio;
            comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = producto.Id;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();
            return filasAfectadas;
        }


        public static int eliminar(int id)
        {
            string consulta = "Delete from dbo.Producto Where Id=@Id";

            comando = new SqlCommand(consulta, AdminDB.conectarDB());
            comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;
            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();
            return filasAfectadas;
        }


        public static int agregar(Producto producto)
        {
            string consulta = "INSERT INTO dbo.Producto (Nombre,Color,Precio) VALUES (@Nombre,@Color,@Precio)";

            comando = new SqlCommand(consulta, AdminDB.conectarDB());

            comando = new SqlCommand(consulta, AdminDB.conectarDB());
            comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = producto.Nombre;
            comando.Parameters.Add("@Color", System.Data.SqlDbType.VarChar, 50).Value = producto.Color;
            comando.Parameters.Add("@Precio", System.Data.SqlDbType.Money).Value = producto.Precio;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();
            return filasAfectadas;
        }

        public static List<Producto> listar()
        {
            string consulta = "SELECT Id, Nombre, Color, Precio FROM dbo.Producto";
            comando = new SqlCommand(consulta, AdminDB.conectarDB());
            SqlDataReader reader = comando.ExecuteReader();

            List<Producto> productos = new List<Producto>();
            while (reader.Read())
            {
                productos.Add(new Producto()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nombre = reader["Nombre"].ToString(),
                    Color = reader["Color"].ToString(),
                    Precio = (decimal)reader["Precio"]
                });
            }
            reader.Close();
            AdminDB.conectarDB().Close();

            return productos;
        }


        public static List<Producto> listar(string color)
        {
            string consulta = "SELECT Id, Nombre, Color, Precio FROM dbo.Producto WHERE Color=@color";

            comando = new SqlCommand(consulta, AdminDB.conectarDB());

            comando.Parameters.Add("@Color", SqlDbType.VarChar, 50).Value = color;

            SqlDataReader reader = comando.ExecuteReader();

            List<Producto> productos = new List<Producto>();
            while (reader.Read())
            {
                productos.Add(new Producto()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nombre = reader["Nombre"].ToString(),
                    Color = reader["Color"].ToString(),
                    Precio = (decimal)reader["Precio"]
                });
            }
            reader.Close();
            AdminDB.conectarDB().Close();

            return productos;
        }


        public static Producto traerProducto(int Id)
        {
            string consulta = "SELECT Id,Nombre,Color,Precio FROM dbo.Producto where Id=@Id";//modificamos
            comando = new SqlCommand(consulta, AdminDB.conectarDB());

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = Id;//modificamos

            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                Producto producto = null;
                while (reader.Read())
                {
                    producto = new Producto()//modificamos
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Nombre = reader["Nombre"].ToString(),
                        Color = reader["Color"].ToString(),
                        Precio = (decimal)reader["Precio"]
                    };
                }
                reader.Close();
                AdminDB.conectarDB().Close();
                return producto;
            }
            else
            {
                AdminDB.conectarDB().Close();
                return null;
            }

        }
    }






}

