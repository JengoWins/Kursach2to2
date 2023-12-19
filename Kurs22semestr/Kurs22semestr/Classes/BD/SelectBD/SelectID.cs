using MasangerRilot.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs22semestr.Classes.BD.SelectBD
{
    class SelectID : BdConnect
    {
        MySqlCommand? commands;

        public int SelectIDWareTech(string name)
        {
            int key = 0;
            string MySqlCode = "select id from warehousetech WHERE id_towar in(SELECT id FROM techical where id_base in (SELECT id FROM basetowar where articul = @n))";
            commands = new MySqlCommand(MySqlCode, conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            adapter.Fill(table);
            key = Convert.ToInt32(table.Rows[0][0]);
            return key;
        }
        public int SelectIDWareBook(string name)
        {
            int key = 0;
            string MySqlCode = "select id from warehousebook WHERE id_towar in(SELECT id FROM book where id_base in (SELECT id FROM basetowar where articul = @n))";
            commands = new MySqlCommand(MySqlCode, conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            adapter.Fill(table);
            key = Convert.ToInt32(table.Rows[0][0]);
            return key;
        }
        public int SelectIDTech(string name)
        {
            int key = 0;
            string MySqlCode = "SELECT id FROM techical where id_base in (SELECT id FROM basetowar where articul = @n)";
            commands = new MySqlCommand(MySqlCode, conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            adapter.Fill(table);
            key = Convert.ToInt32(table.Rows[0][0]);
            return key;
        }
        public int SelectIDBook(string name)
        {
            int key = 0;
            string MySqlCode = "SELECT id FROM book where id_base in (SELECT id FROM basetowar where articul = @n)";
            commands = new MySqlCommand(MySqlCode, conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            adapter.Fill(table);
            key = Convert.ToInt32(table.Rows[0][0]);
            return key;
        }
        public int SelectIDBase(string name)
        {
            int key = 0;
            string MySqlCode = "SELECT id FROM basetowar where articul = @n";
            commands = new MySqlCommand(MySqlCode, conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            adapter.Fill(table);
            key = Convert.ToInt32(table.Rows[0][0]);
            return key;
        }
    }
}
