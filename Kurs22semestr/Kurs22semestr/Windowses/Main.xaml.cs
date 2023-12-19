using Kurs22semestr.Classes.BD;
using Kurs22semestr.Classes.BD.InsertBD;
using Kurs22semestr.Classes.BD.SelectBD;
using Kurs22semestr.Classes.InsertData;
using Kurs22semestr.Classes.ResultData;
using Kurs22semestr.Classes.SettingMainForm.InsertForm;
using Kurs22semestr.Classes.SettingMainForm.SelectForm;
using System;
using System.Data;
using System.Windows;
using System.Windows.Controls;


namespace Kurs22semestr.Windowses
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public static StackPanel? mainPanel;
        public Main()
        {
            InitializeComponent();
            mainPanel = MainStackPanel;
            BDSelectEmployee emp = new BDSelectEmployee();
            string role = "";
            if (Auto.Logins != "Guest")
            {
                role = emp.SelectRole(Auto.Logins);
            }
            else
            {
                 InputsTech.Visibility = Visibility.Hidden;
                 InputsBook.Visibility = Visibility.Hidden;
            }

            switch (role)
            {
                case "Equipment Manager":
                    InputsBook.Visibility = Visibility.Hidden;
                    SelBook.Visibility = Visibility.Hidden;
                    break;
                case "Book Manager":
                    InputsTech.Visibility = Visibility.Hidden;
                    SelTech.Visibility = Visibility.Hidden;
                    break;
            }
            But_Profile.Content = Auto.Logins;
        }

        private void InsertTechnical(object sender, RoutedEventArgs e)
        {
            MainStackPanel.Children.Clear();
            IniLoadInput loadInput = new IniLoadInput();
            loadInput.LoadInputTech(MainStackPanel);
        }
        private void InsertBook(object sender, RoutedEventArgs e)
        {
            MainStackPanel.Children.Clear();
            IniLoadInput loadInput = new IniLoadInput();
            loadInput.LoadInputBook(MainStackPanel);
        }
        private void SelectTechnical(object sender, RoutedEventArgs e)
        {
            MainStackPanel.Children.Clear();
            IniLoadSelect load = new IniLoadSelect(MainStackPanel,1);
        }
        private void SelectBook(object sender, RoutedEventArgs e)
        {
            MainStackPanel.Children.Clear();
            IniLoadSelect load = new IniLoadSelect(MainStackPanel, 2);
        }

        private void Profile(object sender, RoutedEventArgs e)
        {
            Profilexaml prof = new Profilexaml();
            prof.Show();
        }

        private void UpdateTechnical(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateBook(object sender, RoutedEventArgs e)
        {

        }
    }
}
