﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using Kurs22semestr.Classes.BD.DeleteBD;
using Kurs22semestr.Classes.SettingMainForm.InsertForm;
using Kurs22semestr.Windowses;

namespace Kurs22semestr.Classes.ResultData
{
    class TechnicalContainer:Container, InterfaseTechnicalC
    {
        private TextBlock series;
        private TextBlock systems;
        private TextBlock core;
        private TextBlock storeg;
        private TextBlock years;
        private Border br;
        private Button RemoveBut;
        private Button UpdateBut;
        public TechnicalContainer()
        {
            mainContainer = new StackPanel();
            name = new TextBlock();
            articul = new TextBlock();
            discript = new TextBlock();
            price = new TextBlock();
            series = new TextBlock();
            systems = new TextBlock();
            core = new TextBlock();
            storeg = new TextBlock();
            years = new TextBlock();
            br = new Border();
            RemoveBut = new Button();
            UpdateBut = new Button();
        }
        public void SettingBut()
        {
            RemoveBut.Background = Brushes.Red;
            RemoveBut.Width = 100;
            RemoveBut.Height = 25;
            RemoveBut.Margin = new Thickness(5, 0, 5, 0);
            RemoveBut.Content = "Удалить";
            RemoveBut.Click += Delete;

            UpdateBut.Background = Brushes.AliceBlue;
            UpdateBut.Width = 100;
            UpdateBut.Height = 25;
            UpdateBut.Margin = new Thickness(5, 0, 5, 0);
            UpdateBut.Content = "Обновить";
            UpdateBut.Click += Update;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            BDDeleteTech del = new BDDeleteTech();
            del.BdConnsOpen();
            del.DeleteTechWare(articul.Text);
            del.DeleteTech(articul.Text);
            del.DeleteBase(articul.Text);
            del.BdConnsExit();
            MessageBox.Show("Вы удалили запись");
        }
        private void Update(object sender, RoutedEventArgs e)
        {
            IniLoadUpdate upd = new IniLoadUpdate();
            Main.mainPanel.Children.Clear();
            upd.LoadInputTech(Main.mainPanel, name.Text, articul.Text, discript.Text, price.Text, series.Text, systems.Text, core.Text, storeg.Text, years.Text);
        }

        public void SettingName(string n)
        {
            name.Text = n;
            name.Width = 200;
            name.Height = 100;
            name.FontSize = 18;
            name.TextWrapping = TextWrapping.Wrap;
            name.Margin = new Thickness(10);
        }
        public void SettingArticul(string n)
        {
            articul.Text = n;
            articul.Width = 150;
            articul.Height = 100;
            articul.FontSize = 18;
            articul.TextWrapping = TextWrapping.Wrap;
            articul.Margin = new Thickness(10);
        }
        public void SettingDiscript(string n)
        {
            discript.Text = n;
            discript.Width = 300;
            discript.Height = 100;
            discript.FontSize = 18;
            discript.TextWrapping = TextWrapping.Wrap;
            discript.Margin = new Thickness(10);
        }
        public void SettingPrice(string n)
        {
            price.Text = n;
            price.Width = 100;
            price.Height = 100;
            price.FontSize = 18;
            price.TextWrapping = TextWrapping.Wrap;
            price.Margin = new Thickness(10);
        }
        public void SettingSeries(string n)
        {
            series.Text = n;
            series.Width = 150;
            series.Height = 100;
            series.FontSize = 18;
            series.TextWrapping = TextWrapping.Wrap;
            series.Margin = new Thickness(10);
        }
        public void SettingSystem(string n)
        {
            systems.Text = n;
            systems.Width = 200;
            systems.Height = 100;
            systems.FontSize = 18;
            systems.TextWrapping = TextWrapping.Wrap;
            systems.Margin = new Thickness(10);
        }
        public void SettingCore(string n)
        {
            core.Text = n;
            core.Width = 100;
            core.Height = 100;
            core.FontSize = 18;
            core.TextWrapping = TextWrapping.Wrap;
            core.Margin = new Thickness(10);
        }

        public void SettingStore(string n)
        {
            storeg.Text = n;
            storeg.Width = 100;
            storeg.Height = 100;
            storeg.FontSize = 18;
            storeg.TextWrapping = TextWrapping.Wrap;
            storeg.Margin = new Thickness(10);
        }

        public void SettingYear(string n)
        {
            years.Text = n;
            years.Width = 100;
            years.Height = 100;
            years.FontSize = 18;
            years.TextWrapping = TextWrapping.Wrap;
            years.Margin = new Thickness(0);
        }


        public void SettingStack(bool isBool)
        {
            //---------------------------------
            mainContainer.Orientation = Orientation.Horizontal;
            mainContainer.Margin = new Thickness(0);
            //----------------------------------
            mainContainer.Children.Add(name);
            mainContainer.Children.Add(articul);
            mainContainer.Children.Add(discript);
            mainContainer.Children.Add(price);
            mainContainer.Children.Add(series);
            mainContainer.Children.Add(systems);
            mainContainer.Children.Add(core);
            mainContainer.Children.Add(storeg);
            mainContainer.Children.Add(years);
            if (isBool && Auto.Logins != "Guest")
            {
                mainContainer.Children.Add(RemoveBut);
                mainContainer.Children.Add(UpdateBut);
            }
            br.BorderThickness = new Thickness(2);
            br.Padding = new Thickness(15);
            br.Margin = new Thickness(10);
            br.BorderBrush = Brushes.Black;
            br.Child = mainContainer;
        }

        public Border Result()
        {
            return br;
        }
    }
}
