using MasangerRilot.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs22semestr.Classes.BD.DeleteBD
{
    class BDDeleteBook : BdConnect
    {
        MySqlCommand? commands;

        public void DeleteBookWare(string name)
        {
            string MySqlCode = "DELETE FROM warehousebook WHERE id_towar in(SELECT id FROM techical where id_base in (SELECT id FROM basetowar where articul = @n))";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;

            commands.ExecuteNonQuery();
        }
        public void DeleteBook(string name)
        {
            string MySqlCode = "DELETE FROM book where id_base in (SELECT id FROM basetowar where articul = @n)";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;

            commands.ExecuteNonQuery();
        }
        public void DeleteBase(string name)
        {
            string MySqlCode = "DELETE FROM basetowar where articul = @n";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;

            commands.ExecuteNonQuery();
        }
    }
}
