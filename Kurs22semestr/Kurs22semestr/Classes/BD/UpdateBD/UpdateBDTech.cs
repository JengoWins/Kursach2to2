using MasangerRilot.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Kurs22semestr.Classes.BD.UpdateBD
{
    class UpdateBDTech:BdConnect
    {
        MySqlCommand? commands;

        public void UpdateBase(string name, string articul, string discript, int price, int keyBase)
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

        public void UpdateTech(string se, string sy,int core,int store,int year, int keyTech)
        {
            string MySqlCode = "UPDATE techical SET series = @se,systems = @sy,core = @c,storeg = @st,years = @ye where id = @id";
            commands = new MySqlCommand(MySqlCode, conn);
            commands.Parameters.Add("@se", MySqlDbType.VarChar).Value = se;
            commands.Parameters.Add("@sy", MySqlDbType.VarChar).Value = sy;
            commands.Parameters.Add("@c", MySqlDbType.Int32).Value = core;
            commands.Parameters.Add("@st", MySqlDbType.Int32).Value = store;
            commands.Parameters.Add("@ye", MySqlDbType.Int32).Value = year;
            commands.Parameters.Add("@id", MySqlDbType.Int32).Value = keyTech;
            commands.ExecuteNonQuery();
        }
        public void UpdateTechWare(int count, int zone, int KeyWare)
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
