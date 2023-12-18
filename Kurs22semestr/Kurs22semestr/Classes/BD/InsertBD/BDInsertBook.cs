using MasangerRilot.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs22semestr.Classes.BD.InsertBD
{
    class BDInsertBook: BdConnect, InterfasesBDBook
    {
        MySqlCommand? commands;

        public void InsertBase(string name, string articul, string discript, int price)
        {
            string MySqlCode = "INSERT INTO basetowar (names,articul,discript,price) " +
                "VALUES (@n,@a,@d,@p)";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            commands.Parameters.Add("@a", MySqlDbType.VarChar).Value = articul;
            commands.Parameters.Add("@d", MySqlDbType.VarChar).Value = discript;
            commands.Parameters.Add("@p", MySqlDbType.Int32).Value = price;

            commands.ExecuteNonQuery();
        }

        public void InsertBook(string author, int pages, string name)
        {
            string MySqlCode0 = "SELECT id FROM basetowar WHERE names=@n";
            int Key = 0;
            MySqlCommand commands2 = new MySqlCommand(MySqlCode0, conn);
            commands2.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;

            using (MySqlDataReader reading = commands2.ExecuteReader())
            {
                while (reading.Read())
                {
                    Key = (int)reading.GetValue(0);
                }
            }

            string MySqlCode = "INSERT INTO book (Autor,pages,id_base) " +
               "VALUES (@a,@p,@id)";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@a", MySqlDbType.VarChar).Value = author;
            commands.Parameters.Add("@p", MySqlDbType.Int32).Value = pages;
            commands.Parameters.Add("@id", MySqlDbType.Int32).Value = Key;

            commands.ExecuteNonQuery();
        }
    }
}
