using Kurs22semestr.Classes.BD.InsertBD;
using Kurs22semestr.Classes.InsertData;
using Kurs22semestr.Windowses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using Kurs22semestr.Classes.BD.SelectBD;
using Kurs22semestr.Classes.BD.UpdateBD;

namespace Kurs22semestr.Classes.SettingMainForm.InsertForm
{
    class IniLoadUpdate : IniLoadInput
    {
        private Button but;
        private string articul;
        public IniLoadUpdate()
        {
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
                but = new Button();
        }

            public void LoadInputTech(StackPanel MainStackPanel, string n, string a, string d, string p, string se, string sy, string core,string store, string y)
            {
                articul = a;
                //Block 1---------------------
                inputTech1.SettingName("Название: ");
                inputTech1.SettingInput(n);
                inputTech1.SettingStack();
                MainStackPanel.Children.Add(inputTech1.Result());
                //Block 1---------------------
                inputTech2.SettingName("Артикул: ");
                inputTech2.SettingInput(a);
                inputTech2.SettingStack();
                MainStackPanel.Children.Add(inputTech2.Result());
                //Block 1---------------------
                inputTech3.SettingName("Описание: ");
                inputTech3.SettingInput(d);
                inputTech3.SettingStack();
                MainStackPanel.Children.Add(inputTech3.Result());
                //Block 1---------------------
                inputTech4.SettingName("Цена: ");
                inputTech4.SettingInput(p);
                inputTech4.SettingStack();
                MainStackPanel.Children.Add(inputTech4.Result());
                //Block 1---------------------
                inputTech5.SettingName("Серия: ");
                inputTech5.SettingInput(se);
                inputTech5.SettingStack();
                MainStackPanel.Children.Add(inputTech5.Result());
                //Block 1---------------------
                inputTech6.SettingName("Система: ");
                inputTech6.SettingInput(sy);
                inputTech6.SettingStack();
                MainStackPanel.Children.Add(inputTech6.Result());
                //Block 1---------------------
                inputTech9.SettingName("Ядро:");
                inputTech9.SettingInput(core);
                inputTech9.SettingStack();
                MainStackPanel.Children.Add(inputTech9.Result());
                //Block 1---------------------
                inputTech7.SettingName("Память:");
                inputTech7.SettingInput(store);
                inputTech7.SettingStack();
                MainStackPanel.Children.Add(inputTech7.Result());
                //Block 1---------------------
                inputTech8.SettingName("Год производства:");
                inputTech8.SettingInput(y);
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

                but.Width = 100;
                but.Height = 100;
                but.Content = "Обновить";

                but.Click += But_ClickTech;
                MainStackPanel.Children.Add(but);
            }

            private void But_ClickTech(object sender, RoutedEventArgs e)
            {
                SelectID id = new SelectID();
                UpdateBDTech updateBDTech = new UpdateBDTech();
                id.BdConnsOpen();
                int KeyBase = id.SelectIDBase(articul);
                int KeyTech = id.SelectIDTech(articul);
                int KeyWare = id.SelectIDWareTech(articul);
                id.BdConnsExit();
                updateBDTech.BdConnsOpen();
                updateBDTech.UpdateBase(inputTech1.Output, inputTech2.Output, inputTech3.Output, Convert.ToInt32(inputTech4.Output),KeyBase);
                updateBDTech.UpdateTech(inputTech5.Output, inputTech6.Output, Convert.ToInt32(inputTech9.Output), Convert.ToInt32(inputTech7.Output), Convert.ToInt32(inputTech8.Output),KeyTech);
                updateBDTech.UpdateTechWare(Convert.ToInt32(inputTech10.Output), Convert.ToInt32(inputTech11.Output), KeyWare);
                updateBDTech.BdConnsExit();

            }
            public void LoadInputBook(StackPanel MainStackPanel,string n,string a,string d,string p,string au,string pag)
            {
                articul = a;
                //Block 1---------------------
                inputTech1.SettingName("Название: ");
                inputTech1.SettingInput(n);
                inputTech1.SettingStack();
                MainStackPanel.Children.Add(inputTech1.Result());
                //Block 1---------------------
                inputTech2.SettingName("Артикул: ");
                inputTech2.SettingInput(a);
                inputTech2.SettingStack();
                MainStackPanel.Children.Add(inputTech2.Result());
                //Block 1---------------------
                inputTech3.SettingName("Описание: ");
                inputTech3.SettingInput(d);
                inputTech3.SettingStack();
                MainStackPanel.Children.Add(inputTech3.Result());
                //Block 1---------------------
                inputTech4.SettingName("Цена: ");
                inputTech4.SettingInput(p);
                inputTech4.SettingStack();
                MainStackPanel.Children.Add(inputTech4.Result());
                //Block 1---------------------
                inputTech5.SettingName("Автор: ");
                inputTech5.SettingInput(au);
                inputTech5.SettingStack();
                MainStackPanel.Children.Add(inputTech5.Result());
                //Block 1---------------------
                inputTech6.SettingName("Страницы: ");
                inputTech6.SettingInput(pag);
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

                but.Width = 100;
                but.Height = 100;
                but.Content = "Обновить";

                but.Click += But_ClickBook;
                MainStackPanel.Children.Add(but);
            }

            private void But_ClickBook(object sender, RoutedEventArgs e)
            {
                SelectID id = new SelectID();
                UpdateBDBook updateBDBook = new UpdateBDBook();
                id.BdConnsOpen();
                int KeyBase = id.SelectIDBase(inputTech2.Output);
                int KeyBook = id.SelectIDBook(inputTech2.Output);
                int KeyWare = id.SelectIDWareBook(inputTech2.Output);
                id.BdConnsExit();
                updateBDBook.BdConnsOpen();
                updateBDBook.UpdateBase(inputTech1.Output, inputTech2.Output, inputTech3.Output, Convert.ToInt32(inputTech4.Output), KeyBase);
                updateBDBook.UpdateBook(inputTech5.Output, Convert.ToInt32(inputTech6.Output), KeyBook);
                updateBDBook.UpdateBookWare(Convert.ToInt32(inputTech10.Output), Convert.ToInt32(inputTech11.Output), KeyWare);
                updateBDBook.BdConnsExit();
            }
        }
}
