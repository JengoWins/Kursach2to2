using MySql.Data.MySqlClient;
using System;

namespace MasangerRilot.Classes
{
    class BdConnect
    {
        protected string conns;
        protected MySqlConnection conn;

        public BdConnect() {
            try
            {
                conns = "Server=" + "localhost" + ";Database=" + "Warehouse" + ";port=" + "3306" + ";User=" + "root" + ";password=" + "SaraParker206";
                conn = new MySqlConnection(conns);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка подключение к Базе Данных к основному ПК - " + e.Message);
                Console.WriteLine("Попытка подключения к базе данных второму ПК");
            }
            /*
            finally
            {
                conns = "Server=" + "localhost" + ";Database=" + "Warehouse" + ";port=" + "3306" + ";User=" + "root" + ";password=" + "123";
                conn = new MySqlConnection(conns);
            }  
            */
        }
        public BdConnect(string host, string database, string port, string user, string password)
        {
            conns = "Server=" + host + ";Database=" + database + ";port=" + port + ";User=" + user + ";password=" + password;
            conn = new MySqlConnection(conns);
        }

        public void BdConnsOpen()
        {
            conn.Open();
        }

        public void BdConnsExit()
        {
            conn.Close();
        }
    }
}
