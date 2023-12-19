using Kurs22semestr.Classes.BD.SelectBD;
using MasangerRilot.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs22semestr.Classes.BD.UpdateBD
{
    class UpdateBDBook : BdConnect
    {
        MySqlCommand? commands;

        public void UpdateBase(string name, string articul, string discript, int price,int keyBase)
        {
            string MySqlCode = "UPDATE basetowar SET names = @n,articul = @a,discript = @d,price = @p where id = @id";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            commands.Parameters.Add("@a", MySqlDbType.VarChar).Value = articul;
            commands.Parameters.Add("@d", MySqlDbType.VarChar).Value = discript;
            commands.Parameters.Add("@p", MySqlDbType.Int32).Value = price;
            commands.Parameters.Add("@id", MySqlDbType.Int32).Value = keyBase;
            commands.ExecuteNonQuery();
        }

        public void UpdateBook(string author, int pages, int keyBook)
        { 
            string MySqlCode = "UPDATE book SET Autor = @a,pages = @p where id = @id";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@a", MySqlDbType.VarChar).Value = author;
            commands.Parameters.Add("@p", MySqlDbType.Int32).Value = pages;
            commands.Parameters.Add("@id", MySqlDbType.Int32).Value = keyBook;
            commands.ExecuteNonQuery();
        }
        public void UpdateBookWare(int count, int zone, int KeyWare)
        {
            string MySqlCode = "UPDATE warehousetech SET count = @c,category_zone = @cat where id = @id";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@id", MySqlDbType.VarChar).Value = KeyWare;
            commands.Parameters.Add("@c", MySqlDbType.Int32).Value = count;
            commands.Parameters.Add("@cat", MySqlDbType.Int32).Value = zone;
            commands.ExecuteNonQuery();
        }


    }
}
