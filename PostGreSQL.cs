using System;
using System.Windows.Forms;
using Npgsql;
using System.Collections.Generic;

namespace PgSql
{
    public class PostGreSQL
    {
        List<string> sehir = new List<string>();
        List<string> otobus = new List<string>();
        public void PostgreSQL()
        {
        }

        public List<string> PostgreSQLsehir1()
        {
            try
            {
                string satir = "SELECT * FROM " + '"' + "public" + '"' + "." + '"' + "sehir" + '"';
                string connstring = "Server=localhost; User Id=postgres; Password=16101210; Database=Odev3_B171210309_HusneIremKaya_31A;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(satir, connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    sehir.Add(dataReader[1].ToString() + "\r\n");
                }
                connection.Close();
                return sehir;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }
        public List<string> PostgreSQLotobus()
        {
            try
            {
                string satir = "SELECT * FROM " + '"' + "public" + '"' + "." + '"' + "otobus" + '"';
                string connstring = "Server=localhost; User Id=postgres; Password=16101210; Database=Odev3_B171210309_HusneIremKaya_31A;";
                NpgsqlConnection connection = new NpgsqlConnection(connstring);
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(satir, connection);
                NpgsqlDataReader dataReader = command.ExecuteReader();
                for (int i = 0; dataReader.Read(); i++)
                {
                    otobus.Add(dataReader[1].ToString() + "\r\n");
                }
                connection.Close();
                return otobus;
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.ToString());
                throw;
            }
        }




    }
}