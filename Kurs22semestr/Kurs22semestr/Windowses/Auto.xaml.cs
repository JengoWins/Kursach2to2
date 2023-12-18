using Kurs22semestr.Classes.BD;
using Kurs22semestr.Classes.Correct;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Auto.xaml
    /// </summary>
    public partial class Auto : Window
    {
        CorrectLogins CorrectLog;
        CorrectPass CorreacPass;
        
        public static string? Logins { get; set; }
        public Auto()
        {
            InitializeComponent();
        }

        private void InMainWindow(object sender, RoutedEventArgs e)
        {
            
            try
            {
                CorrectLog = new CorrectLogins(Login.Text);
                CorreacPass = new CorrectPass(Password.Password);
                if (CorrectLog.CheckAccount() && CorreacPass.CheckInInput())
                {
                    BDSelectEmployee BDSelectCommand = new BDSelectEmployee();
                    BDSelectCommand.BdConnsOpen();
                    bool isNext = BDSelectCommand.SelectEmployeeAccount(Login.Text, Password.Password);
                    BDSelectCommand.BdConnsExit();
                    if (isNext)
                    {
                        Logins = Login.Text;
                        Main MainWin = new Main();
                        MainWin.Show();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка SQL команды." + ex.Message);
            }
            
            
        }

        private void Guest(object sender, RoutedEventArgs e)
        {
            Logins = "Guest";
            Main MainWin = new Main();
            MainWin.Show();
            this.Close();
        }
    }
}
