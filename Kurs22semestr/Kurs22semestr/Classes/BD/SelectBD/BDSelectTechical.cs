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
    class BDSelectTechical: BdConnect, InterfasesBDSelect
    {
        MySqlCommand? commands;

        public DataTable SelectTowar()
        {
            string MySqlCode = "select names,articul,discript,price,Series,systems,core,storeg,years from basetowar join techical on basetowar.id = techical.Id_Base;";
            MySqlCommand commands = new MySqlCommand(MySqlCode, conn);
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(commands);
            adapter.Fill(table);
            return table;
        }
    }
}
