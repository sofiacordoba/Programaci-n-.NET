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
    public static class AdminAutores
    {
        //[au_id],[au_lname],[au_fname],[phone],[address],[city],[state],[zip],[contract]
        public static List<Author> Lista()
        {
            List<Author> lista = new List<Author>();

            //configurar el objeto de conexion


            //preparando la consulta SQL
            string consulta = "SELECT [au_id],[au_lname],[au_fname],[phone],[address],[city],[state],[zip],[contract] FROM [dbo].[authors];

            //comando 
            SqlCommand comando = new SqlCommand(consulta, AdminDB.conexion());


            //reader
            SqlDataReader reader = comando.ExecuteReader();

            //leer los datos
            while (reader.Read())
            {
                lista.Add(new Author()
                {
                    Au_id = reader["au_id"].ToString(),
                    Au_name = reader["au_lname"].ToString(),
                    Au_fname = reader["au_fname"].ToString(),
                    Phone = reader["phone"].ToString(),
                    Adress = reader["adress"].ToString(),
                    City = reader["city"].ToString(),
                    State = reader["state"].ToString(),
                    Zip = reader["zip"].ToString()
                    Contract = reader["contract"].ToString(),
                });
            }
            //[au_id],[au_lname],[au_fname],[phone],[address],[city],[state],[zip],[contract]
            reader.Close();
            AdminDB.conexion().Close();
            return lista;
        }

        public static int Agregar(Author author)
        {
            //query insert
            string consulta = "INSERT INTO[dbo].[publishers]([pub_id],[pub_name],[city],[state],[country])VALUES(@pub_id,@pub_name,@city,@state,@country)";
            //sqlcommand
            SqlCommand command = new SqlCommand(consulta, AdminDB.conexion());

            //parametros
            command.Parameters.Add("@au_id", System.Data.SqlDbType.VarChar, 11).Value = author.Au_id;
            command.Parameters.Add("@au_lname", System.Data.SqlDbType.VarChar, 40).Value = author.Au_lname;
            command.Parameters.Add("@au_fname", System.Data.SqlDbType.VarChar, 20).Value = author.Au_fname;
            command.Parameters.Add("@phone", System.Data.SqlDbType.VarChar, 12).Value = author.Phone;
            command.Parameters.Add("@adress", System.Data.SqlDbType.VarChar, 40).Value = author.Adress;
            command.Parameters.Add("@city", System.Data.SqlDbType.VarChar, 20).Value = author.City;
            command.Parameters.Add("@state", System.Data.SqlDbType.VarChar, 2).Value = author.State;
            command.Parameters.Add("@zip", System.Data.SqlDbType.VarChar, 5).Value = author.Zip;
            command.Parameters.Add("@contract", System.Data.SqlDbType.Bit).Value = author.Contract;

            //ejecutar el comando para enviar los datos a db (data base)
            int filasAfectadas = command.ExecuteNonQuery();
            AdminDB.conexion().Close();
            return filasAfectadas;
        }
    }
}
