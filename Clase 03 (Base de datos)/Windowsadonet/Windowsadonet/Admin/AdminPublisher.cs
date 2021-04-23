using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windowsadonet.Models;
using Windowsadonet.BaseDatos;

namespace Windowsadonet.Admin
{
    public static class AdminPublisher

    {
        public static List<Publisher> Lista()
        {
            List<Publisher> lista = new List<Publisher>();

            //configurar el objeto de conexion


            //preparando la consulta SQL
            string consulta = "SELECT [pub_id],[pub_name],[city],[state],[country] FROM [dbo].[publishers]";

            //comando 
            SqlCommand comando = new SqlCommand(consulta, AdminDB.conexion());


            //reader
            SqlDataReader reader = comando.ExecuteReader();

            //leer los datos
            while (reader.Read())
            {
                lista.Add( new Publisher()
                {
                    Pub_id = reader["pub_id"].ToString(),
                    Pub_name = reader["pub_id"].ToString(),
                    City = reader["city"].ToString(),
                    State = reader["state"].ToString(),
                    Country = reader["country"].ToString()
                });
            }
            reader.Close();
            AdminDB.conexion().Close();
            return lista;
        }

        public static int Agregar(Publisher publisher)
        {
            //query insert
            string consulta = "INSERT INTO[dbo].[publishers]([pub_id],[pub_name],[city],[state],[country])VALUES(@pub_id,@pub_name,@city,@state,@country)";
            //sqlcommand
            SqlCommand command = new SqlCommand(consulta, AdminDB.conexion());

            //parametros
            command.Parameters.Add("@pub_id",System.Data.SqlDbType.Char,4).Value = publisher.Pub_id;
            command.Parameters.Add("@pub_name", System.Data.SqlDbType.VarChar, 40).Value = publisher.Pub_name;
            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 20).Value = publisher.City;
            command.Parameters.Add("@state", System.Data.SqlDbType.VarChar, 2).Value = publisher.State;
            command.Parameters.Add("@country", System.Data.SqlDbType.VarChar, 30).Value = publisher.Country;

            //ejecutar el comando para enviar los datos a db (data base)
            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.conexion().Close();
            return filasAfectadas;
        }

    }
}
