using MasangerRilot.Classes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Data;
using System.Windows;

namespace Kurs22semestr.Classes.BD
{
    class BDSelectEmployee : BdConnect, InterfasesBDSelect
    {
        MySqlCommand? commands;
        public bool SelectEmployee(string log)
        {
            bool isTrue = false;
            string MySqlCode = "SELECT COUNT(*) FROM accounts WHERE nickname=@l";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;

            if (Convert.ToInt32(commands.ExecuteScalar()) > 0)
            {
                isTrue = true;
            }
            return isTrue;
        }

        public bool SelectEmployee(string log, string pass)
        {
            bool isTrue = false;
            string MySqlCode = "SELECT COUNT(*) FROM accounts WHERE nickname=@l and passwords=@p";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;
            commands.Parameters.Add("@p", MySqlDbType.VarChar).Value = pass;
            if (Convert.ToInt32(commands.ExecuteScalar()) > 0)
            {
                isTrue = true;
            }
            return isTrue;
        }
        /*
        public DataTable SelectUsers(string log,MySqlConnection conn)
        {
            string MySqlCodeID = "SELECT id_DiscriptionUser FROM accounts join users on accounts.id=id_Account WHERE nickname!=@l";
            string MySqlCode = "SELECT nickname,discription,photo FROM accounts,discriptionuser WHERE nickname!=@l and discriptionuser.id = ("+ MySqlCodeID + ")";
            MySqlCommand commands = new MySqlCommand(MySqlCode, conn);
            DataTable table = new DataTable();
            commands.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            adapter.Fill(table);
            return table;
        }
        */
    }
}
