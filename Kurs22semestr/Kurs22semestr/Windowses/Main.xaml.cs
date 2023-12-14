using Kurs22semestr.Classes.BD.InsertBD;
using Kurs22semestr.Classes.InsertData;
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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        BlockInput inputTech1;
        BlockInput inputTech2;
        BlockInput inputTech3;
        BlockInput inputTech4;
        BlockInput inputTech5;
        BlockInput inputTech6;
        BlockInput inputTech7;
        BlockInput inputTech8;
        BlockInput inputTech9;
        public Main()
        {
            InitializeComponent();
            inputTech1 = new BlockInput();
            inputTech2 = new BlockInput();
            inputTech3 = new BlockInput();  
            inputTech4 = new BlockInput();
            inputTech5 = new BlockInput();
            inputTech6 = new BlockInput();
            inputTech7 = new BlockInput();
            inputTech8 = new BlockInput();
            inputTech9 = new BlockInput();
        }

        private void InsertTechnical(object sender, RoutedEventArgs e)
        {
            LoadInput();
        }
        private void InsertBook(object sender, RoutedEventArgs e)
        {

        }
        private void SelectTechnical(object sender, RoutedEventArgs e)
        {

        }
        private void SelectBook(object sender, RoutedEventArgs e)
        {

        }

        private void LoadInput()
        {
            //Block 1---------------------
            inputTech1.SettingName("Название: ");
            inputTech1.SettingInput();
            inputTech1.SettingStack();
            MainStackPanel.Children.Add(inputTech1.Result());
            //Block 1---------------------
            inputTech2.SettingName("Артикул: ");
            inputTech2.SettingInput();
            inputTech2.SettingStack();
            MainStackPanel.Children.Add(inputTech2.Result());
            //Block 1---------------------
            inputTech3.SettingName("Описание: ");
            inputTech3.SettingInput();
            inputTech3.SettingStack();
            MainStackPanel.Children.Add(inputTech3.Result());
            //Block 1---------------------
            inputTech4.SettingName("Цена: ");
            inputTech4.SettingInput();
            inputTech4.SettingStack();
            MainStackPanel.Children.Add(inputTech4.Result());
            //Block 1---------------------
            inputTech5.SettingName("Серия: ");
            inputTech5.SettingInput();
            inputTech5.SettingStack();
            MainStackPanel.Children.Add(inputTech5.Result());
            //Block 1---------------------
            inputTech6.SettingName("Система: ");
            inputTech6.SettingInput();
            inputTech6.SettingStack();
            MainStackPanel.Children.Add(inputTech6.Result());
            //Block 1---------------------
            inputTech9.SettingName("Ядро:");
            inputTech9.SettingInput();
            inputTech9.SettingStack();
            MainStackPanel.Children.Add(inputTech9.Result());
            //Block 1---------------------
            inputTech7.SettingName("Память:");
            inputTech7.SettingInput();
            inputTech7.SettingStack();
            MainStackPanel.Children.Add(inputTech7.Result());
            //Block 1---------------------
            inputTech8.SettingName("Год производства:");
            inputTech8.SettingInput();
            inputTech8.SettingStack();
            MainStackPanel.Children.Add(inputTech8.Result());

            Button but = new Button();
            but.Width = 100;
            but.Height = 100;
            but.Content = "Записать";

            but.Click += But_Click;
            MainStackPanel.Children.Add(but);
        }

        private void But_Click(object sender, RoutedEventArgs e)
        {
            BDInsertTechical insert = new BDInsertTechical();
            insert.BdConnsOpen();
            insert.InsertBase(inputTech1.Output, inputTech2.Output, inputTech3.Output, Convert.ToInt32(inputTech4.Output));
            insert.InsertTechical(inputTech5.Output, inputTech6.Output, Convert.ToInt32(inputTech9.Output), Convert.ToInt32(inputTech7.Output), Convert.ToInt32(inputTech8.Output), inputTech1.Output);
            insert.BdConnsExit();
        }
    }
}
