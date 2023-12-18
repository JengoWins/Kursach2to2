using MasangerRilot.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs22semestr.Classes.BD.InsertBD
{
    class BDInsertWareTech : BdConnect, InterfasesBDWareTech
    {
        MySqlCommand? commands;
        public void InsertTechical(int count, int zone, string emp,string towar)
        {
            string MySqlCode0 = "SELECT id_Employee FROM accountemp where id_Account in (SELECT id FROM accounts WHERE nickname=@l)";
            int KeyEmp = 0;
            MySqlCommand commands2 = new MySqlCommand(MySqlCode0, conn);
            commands2.Parameters.Add("@l", MySqlDbType.VarChar).Value = emp;

            using (MySqlDataReader reading = commands2.ExecuteReader())
            {
                while (reading.Read())
                {
                    KeyEmp = (int)reading.GetValue(0);
                }
            }

            string MySqlCode1 = "SELECT id FROM techical where id_base in (SELECT id FROM basetowar WHERE names=@t)";
            int KeyTowar = 0;
            MySqlCommand commands1 = new MySqlCommand(MySqlCode1, conn);
            commands1.Parameters.Add("@t", MySqlDbType.VarChar).Value = towar;

            using (MySqlDataReader reading = commands1.ExecuteReader())
            {
                while (reading.Read())
                {
                    KeyTowar = (int)reading.GetValue(0);
                }
            }

            string MySqlCode = "INSERT INTO warehousetech (id_towar,id_employee,count,category_zone) " +
               "VALUES (@k1,@k2,@c,@cat)";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@k1", MySqlDbType.VarChar).Value = KeyTowar;
            commands.Parameters.Add("@k2", MySqlDbType.VarChar).Value = KeyEmp;
            commands.Parameters.Add("@c", MySqlDbType.Int32).Value = count;
            commands.Parameters.Add("@cat", MySqlDbType.Int32).Value = zone;

            commands.ExecuteNonQuery();
        }
    }
}
