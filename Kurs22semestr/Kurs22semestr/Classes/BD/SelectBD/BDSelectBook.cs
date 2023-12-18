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
    class BDSelectBook: BdConnect, InterfasesBDSelect
    {
        MySqlCommand? commands;

        public DataTable SelectTowar()
        {
            string MySqlCode = "select names,articul,discript,price,autor,pages from basetowar join book on basetowar.id = book.Id_Base;";
            MySqlCommand commands = new MySqlCommand(MySqlCode, conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            adapter.Fill(table);
            return table;
        }
    }
}
