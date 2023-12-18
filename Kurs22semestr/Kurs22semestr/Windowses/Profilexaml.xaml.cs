using Kurs22semestr.Classes.BD;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Kurs22semestr.Windowses
{
    /// <summary>
    /// Логика взаимодействия для Profilexaml.xaml
    /// </summary>
    public partial class Profilexaml : Window
    {
        public Profilexaml()
        {
            InitializeComponent();
            LoadProfile();
        }

        private void LoadProfile()
        {
            BDSelectEmployee emp = new BDSelectEmployee();
            if (Auto.Logins != "Guest")
            {
                DataTable table = emp.SelectEmployee(Auto.Logins);
                Users.Text = "Аккаунт: "+Auto.Logins;
                first_name.Text = "Фамилия: "+table.Rows[0][0].ToString();
                last_name.Text = "Имя: " + table.Rows[0][1].ToString();
                Father_name.Text = "Отчество: " + table.Rows[0][2].ToString();
                Date.Text = "Дата: " + table.Rows[0][3].ToString();
                Salary.Text = "Зарплата: " + table.Rows[0][4].ToString();
                Role.Text = "Роль: " + table.Rows[0][5].ToString();
            }
            else
            {
                Users.Text = "Аккаунт: " + Auto.Logins;
                first_name.Text = "Фамилия: " + "Guest";
                last_name.Text = "Имя: " + "Guest";
                Father_name.Text = "Отчество: " + "Guest";
                Date.Text = "Дата: " + DateTime.Now.ToString();
                Salary.Text = "Зарплата: " + "0";
                Role.Text = "Роль: " + "Guest";
            }
            
        }
    }
}
