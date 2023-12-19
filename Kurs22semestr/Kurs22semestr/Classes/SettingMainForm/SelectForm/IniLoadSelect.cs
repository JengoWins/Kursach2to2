using Kurs22semestr.Classes.BD.SelectBD;
using Kurs22semestr.Classes.InsertData;
using Kurs22semestr.Classes.ResultData;
using Kurs22semestr.Windowses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kurs22semestr.Classes.SettingMainForm.SelectForm
{
    class IniLoadSelect
    {
        StackPanel mainStackPanel;
        public IniLoadSelect(StackPanel MainStackPanel,int i)
        {
            this.mainStackPanel = MainStackPanel;
            switch (i)
            {
                case 1:
                    LoadTechnical();
                    break;
                case 2:
                    LoadBook();
                    break;
            }
           
            MainStackPanel = mainStackPanel;
        }
        private void LoadSelectTech(string one, string two, string three, string four, string fife, string six, string seven, string eight, string nine,bool isBut)
        {
            TechnicalContainer containSelect = new TechnicalContainer();
            containSelect.SettingName(one);
            containSelect.SettingArticul(two);
            containSelect.SettingDiscript(three);
            containSelect.SettingPrice(four);
            containSelect.SettingSeries(fife);
            containSelect.SettingSystem(six);
            containSelect.SettingCore(seven);
            containSelect.SettingStore(eight);
            containSelect.SettingYear(nine);
            if (isBut && Auto.Logins!="Guest")
            {
                containSelect.SettingBut();
            }
            containSelect.SettingStack(isBut);
            mainStackPanel.Children.Add(containSelect.Result());
        }
        private void LoadSelectBook(string one, string two, string three, string four, string fife, string six, bool isBut)
        {
            BookContainer containSelect = new BookContainer();
            containSelect.SettingName(one);
            containSelect.SettingArticul(two);
            containSelect.SettingDiscript(three);
            containSelect.SettingPrice(four);
            containSelect.SettingAuthor(fife);
            containSelect.SettingPages(six);
            if (isBut && Auto.Logins != "Guest")
            {
                containSelect.SettingBut();
            }
            containSelect.SettingStack(isBut);
            mainStackPanel.Children.Add(containSelect.Result());
        }
        private void LoadBook()
        {
            BDSelectBook select = new BDSelectBook();
            select.BdConnsOpen();
            DataTable dataTable = select.SelectTowar();
            select.BdConnsExit();
            LoadSelectBook("Название", "Артикул", "Описание", "Цена", "Автор", "Кол-во страниц",false);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string? n = dataTable.Rows[i][0].ToString();
                string? a = dataTable.Rows[i][1].ToString();
                string? d = dataTable.Rows[i][2].ToString();
                string? p = dataTable.Rows[i][3].ToString();
                string? se = dataTable.Rows[i][4].ToString();
                string? sy = dataTable.Rows[i][5].ToString();

                LoadSelectBook(n, a, d, p, se, sy,true);
            }
        }
        private void LoadTechnical()
        {
            BDSelectTechical select = new BDSelectTechical();
            select.BdConnsOpen();
            DataTable dataTable = select.SelectTowar();
            select.BdConnsExit();
            LoadSelectTech("Название", "Артикул", "Описание", "Цена", "Серия", "Кол-во ядер", "Кол-во Памяти", "Память", "Год выпуска",false);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string? n = dataTable.Rows[i][0].ToString();
                string? a = dataTable.Rows[i][1].ToString();
                string? d = dataTable.Rows[i][2].ToString();
                string? p = dataTable.Rows[i][3].ToString();
                string? se = dataTable.Rows[i][4].ToString();
                string? sy = dataTable.Rows[i][5].ToString();
                string? c = dataTable.Rows[i][6].ToString();
                string? s = dataTable.Rows[i][7].ToString();
                string? y = dataTable.Rows[i][8].ToString();

                LoadSelectTech(n, a, d, p, se, sy, c, s, y,true);
            }
        }
    }
}
