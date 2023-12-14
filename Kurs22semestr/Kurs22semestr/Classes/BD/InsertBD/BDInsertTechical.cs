using Kurs22semestr.Classes;
using MasangerRilot.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Xml.Linq;

namespace Kurs22semestr.Classes.BD.InsertBD
{
    class BDInsertTechical : BdConnect, InterfasesBDInsert
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

        public void InsertTechical(string series, string systems, int core, int store, int year,string name)
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

            string MySqlCode = "INSERT INTO techical (series,systems,core,storeg,years,id_base) " +
               "VALUES (@se,@sy,@c,@st,@ye,@id)";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@se", MySqlDbType.VarChar).Value = series;
            commands.Parameters.Add("@sy", MySqlDbType.VarChar).Value = systems;
            commands.Parameters.Add("@c", MySqlDbType.Int32).Value = core;
            commands.Parameters.Add("@st", MySqlDbType.Int32).Value = store;
            commands.Parameters.Add("@ye", MySqlDbType.Int32).Value = year;
            commands.Parameters.Add("@id", MySqlDbType.Int32).Value = Key;

            commands.ExecuteNonQuery();
        }
    }
}
