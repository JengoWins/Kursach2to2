using Kurs22semestr.Classes.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Kurs22semestr.Classes.Correct
{
    class CorrectLogins
    {
        private string login;
        public string Login {  get { return login; } }
        public CorrectLogins(string str) {
            login = str;
        }

        public bool CheckAccount()
        {
            bool isBool = false;
            BDSelectEmployee select = new BDSelectEmployee();
            select.BdConnsOpen();
            try
            {
                isBool = select.SelectEmployeeAccount(login);
                if (isBool)
                {
                    MessageBox.Show("Логин совпадает с данными в базе данных.","Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Логин не совпадает с данными из базы данных. Введите другой логин.","Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка SQL команды." + ex.Message);
            }
            select.BdConnsExit();
            return isBool;
            
        }
    }
}
