using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // agregar 
using Entidades.Models;
using Negocio.Admin;

namespace Negocio.Admin

{
    public static class AdminCliente
    {
        public static List <Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();

           /* //configurar el objeto de conexion
            string cadena = "Data Source=.;Initial Catalog=DBFACTURACION;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(cadena); */

            //preparando la consulta SQL
            string consulta = "SELECT [Id],[Nombre],[Apellido],[FechaNacimiento] FROM [dbo].[Cliente]";

            //comando
            SqlCommand comando = new SqlCommand(consulta, AdminDB.conectarDB());

            //reader
            SqlDataReader reader = comando.ExecuteReader();

            //leer los datos
            while (reader.Read())  // debo llenar una lista
            {
                lista.Add(
                    new Cliente()
                    {
                        Id = (int)reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        FechaNacimiento = (DateTime)reader["FechaNacimiento"]
                    });
                    
            }
            reader.Close();
            AdminDB.conectarDB().Close();
            return lista;
        }

        public static int Agregar(Cliente cliente) // devuelve cantidad de filas afectadas(int)
        {
            //query insert  (la preparo en sql)
            string consulta = "INSERT INTO [dbo].[Cliente]([Id],[Nombre],[Apellido]," +
                             "[FechaNacimiento]) VALUES (@id,@nombre,@apellido,@fechanacimiento)";

            //sqlcommand
            SqlCommand command = new SqlCommand(consulta, AdminDB.conectarDB());

            //parametros
            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = cliente.Id;
            command.Parameters.Add("@nombre", System.Data.SqlDbType.VarChar,50).Value = cliente.Nombre;
            command.Parameters.Add("@apellido", System.Data.SqlDbType.VarChar,50).Value = cliente.Apellido;
            command.Parameters.Add("@fechanacimiento", System.Data.SqlDbType.Date).Value = cliente.FechaNacimiento;

            //ejecutar el comando para enviar los datos a DB
            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.conectarDB().Close();
            return filasAfectadas;
        }
    }
}
