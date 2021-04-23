using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibDatosProducto.Models;
using System.Data.SqlClient;
using LibDatosProducto.BaseDatos;

namespace LibDatosProducto.Repositorios
{
    public static class AdminCategoria
    {
        private static SqlCommand comando;
        private static SqlDataReader reader;
        public static int modificar(Categoria categoria)
        {
            string consulta = "UPDATE [dbo].[Categoria] SET Nombre = @Nombre,Descripcion = @Descripcion WHERE Id= @Id";

            comando = new SqlCommand(consulta, AdminDB.conectarDB());

            comando = new SqlCommand(consulta, AdminDB.conectarDB());
            comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = categoria.Nombre;
            comando.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar, 150).Value = categoria.Descripcion;
            comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = categoria.Id;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();
            return filasAfectadas;
        }


        public static int eliminar(int id)
        {
            string consulta = "Delete from dbo.Categoria Where Id=@Id";

            comando = new SqlCommand(consulta, AdminDB.conectarDB());
            comando.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;
            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();
            return filasAfectadas;
        }


        public static int agregar(Categoria categoria)
        {
            string consulta = "INSERT INTO dbo.Categoria (Nombre, Descripcion) VALUES (@Nombre,@Descripcion)";

            comando = new SqlCommand(consulta, AdminDB.conectarDB());

            comando = new SqlCommand(consulta, AdminDB.conectarDB());
            comando.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 50).Value = categoria.Nombre;
            comando.Parameters.Add("@Descripcion", System.Data.SqlDbType.VarChar, 150).Value = categoria.Descripcion;

            int filasAfectadas = comando.ExecuteNonQuery();
            AdminDB.conectarDB().Close();
            return filasAfectadas;
        }
    }
}
