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
        public bool SelectEmployeeAccount(string log)
        {
            bool isTrue = false;
            string MySqlCode = "SELECT COUNT(*) FROM accounts WHERE nickname=@l;";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;

            if (Convert.ToInt32(commands.ExecuteScalar()) > 0)
            {
                isTrue = true;
            }
            return isTrue;
        }

        public bool SelectEmployeeAccount(string log, string pass)
        {
            bool isTrue = false;
            string MySqlCode = "SELECT COUNT(*) FROM accounts WHERE nickname=@l and passwords=@p;";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;
            commands.Parameters.Add("@p", MySqlDbType.VarChar).Value = pass;
            if (Convert.ToInt32(commands.ExecuteScalar()) > 0)
            {
                isTrue = true;
            }
            return isTrue;
        }

        public string SelectRole(string log)
        {
            string MySqlCode = "select positions from positions where id in (select id_position from accountemp where id_Account in (select id from accounts where nickname = @l));";
            MySqlCommand commands = new MySqlCommand(MySqlCode, conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            commands.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;
            adapter.Fill(table);
            string? result = table.Rows[0][0].ToString();

            return result;
        }
        public DataTable SelectEmployee(string log)
        {
            string MySqlCode = "select first_name,last_name,father_name,Date_of_birth,salary,positions from employee join positions on employee.id = positions.id where employee.id in( select id_Employee from accountemp where id_Account in (select id from accounts where nickname = @l));";
            MySqlCommand commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@l", MySqlDbType.VarChar).Value = log;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            adapter.Fill(table);

            return table;
        }
      
    }
}
