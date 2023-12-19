using Kurs22semestr.Classes.BD.InsertBD;
using Kurs22semestr.Classes.InsertData;
using Kurs22semestr.Windowses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Kurs22semestr.Classes.SettingMainForm.InsertForm
{
    class IniLoadInput
    {
        protected BlockInput inputTech1;
        protected BlockInput inputTech2;
        protected BlockInput inputTech3;
        protected BlockInput inputTech4;
        protected BlockInput inputTech5;
        protected BlockInput inputTech6;
        protected BlockInput inputTech7;
        protected BlockInput inputTech8;
        protected BlockInput inputTech9;
        //------------------
        protected BlockInput inputTech10;
        protected BlockInput inputTech11;

        public IniLoadInput() {
            inputTech1 = new BlockInput();
            inputTech2 = new BlockInput();
            inputTech3 = new BlockInput();
            inputTech4 = new BlockInput();
            inputTech5 = new BlockInput();
            inputTech6 = new BlockInput();
            inputTech7 = new BlockInput();
            inputTech8 = new BlockInput();
            inputTech9 = new BlockInput();
            inputTech10 = new BlockInput();
            inputTech11 = new BlockInput();
        }

        public void LoadInputTech(StackPanel MainStackPanel)
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

            inputTech10.SettingName("Количество товаров:");
            inputTech10.SettingInput();
            inputTech10.SettingStack();
            MainStackPanel.Children.Add(inputTech10.Result());
            inputTech11.SettingName("Сектор:");
            inputTech11.SettingInput();
            inputTech11.SettingStack();
            MainStackPanel.Children.Add(inputTech11.Result());

            Button but = new Button();
            but.Width = 100;
            but.Height = 100;
            but.Content = "Записать";

            but.Click += But_ClickTech;
            MainStackPanel.Children.Add(but);
        }

        protected void But_ClickTech(object sender, RoutedEventArgs e)
        {
            BDInsertTechical insertTowar = new BDInsertTechical();
            BDInsertWareTech insertWarehouse = new BDInsertWareTech();
            insertTowar.BdConnsOpen();
            insertTowar.InsertBase(inputTech1.Output, inputTech2.Output, inputTech3.Output, Convert.ToInt32(inputTech4.Output));
            insertTowar.InsertTechical(inputTech5.Output, inputTech6.Output, Convert.ToInt32(inputTech9.Output), Convert.ToInt32(inputTech7.Output), Convert.ToInt32(inputTech8.Output), inputTech1.Output);
            insertTowar.BdConnsExit();

            insertWarehouse.BdConnsOpen();
            insertWarehouse.InsertTechical(Convert.ToInt32(inputTech10.Output), Convert.ToInt32(inputTech11.Output),Auto.Logins, inputTech1.Output);
            insertWarehouse.BdConnsExit();
        }
        public void LoadInputBook(StackPanel MainStackPanel)
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
            inputTech5.SettingName("Автор: ");
            inputTech5.SettingInput();
            inputTech5.SettingStack();
            MainStackPanel.Children.Add(inputTech5.Result());
            //Block 1---------------------
            inputTech6.SettingName("Страницы: ");
            inputTech6.SettingInput();
            inputTech6.SettingStack();
            MainStackPanel.Children.Add(inputTech6.Result());

            inputTech10.SettingName("Количество товаров:");
            inputTech10.SettingInput();
            inputTech10.SettingStack();
            MainStackPanel.Children.Add(inputTech10.Result());
            inputTech11.SettingName("Сектор:");
            inputTech11.SettingInput();
            inputTech11.SettingStack();
            MainStackPanel.Children.Add(inputTech11.Result());


            Button but = new Button();
            but.Width = 100;
            but.Height = 100;
            but.Content = "Записать";

            but.Click += But_ClickBook;
            MainStackPanel.Children.Add(but);
        }

        protected void But_ClickBook(object sender, RoutedEventArgs e)
        {
            BDInsertBook insert = new BDInsertBook();
            BDInsertWareBook insertWarehouse = new BDInsertWareBook();
            insert.BdConnsOpen();
            insert.InsertBase(inputTech1.Output, inputTech2.Output, inputTech3.Output, Convert.ToInt32(inputTech4.Output));
            insert.InsertBook(inputTech5.Output, Convert.ToInt32(inputTech6.Output), inputTech1.Output);
            insert.BdConnsExit();

            insertWarehouse.BdConnsOpen();
            insertWarehouse.InsertBook(Convert.ToInt32(inputTech10.Output), Convert.ToInt32(inputTech11.Output), Auto.Logins, inputTech1.Output);
            insertWarehouse.BdConnsExit();
        }
    }
}
