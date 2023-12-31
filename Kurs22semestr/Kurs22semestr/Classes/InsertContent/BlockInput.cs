﻿using Kurs22semestr.Classes.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Drawing;
using System.Windows.Media;

namespace Kurs22semestr.Classes.InsertData
{
    class BlockInput: Container2
    {
        public BlockInput()
        {
            mainContainer = new StackPanel();
            name = new TextBlock();
            input = new TextBox();
        }

        public override string Output { get { return input.Text; } }

        public override void SettingName(string n)
        {
            name.Text = n;
            name.Width = 150;
            name.Height = 50;
            name.FontSize = 18;
            name.TextWrapping = TextWrapping.Wrap;
            input.Margin = new Thickness(10, 0, 10, 0);
        }
        public override void SettingInput()
        {
            input.Width = 100;
            input.Height = 50;
            input.FontSize = 18;
            input.TextWrapping = TextWrapping.Wrap;
            input.Margin = new Thickness(5,0,5,0);
        }
        public void SettingInput(string n)
        {
            input.Text = n;
            input.Width = 100;
            input.Height = 50;
            input.FontSize = 18;
            input.TextWrapping = TextWrapping.Wrap;
            input.Margin = new Thickness(5, 0, 5, 0);
        }

        public override void SettingStack()
        {
            input.Width = 600;
            mainContainer.Background = Brushes.White;
            //---------------------------------
            mainContainer.Orientation = Orientation.Horizontal;
            mainContainer.Margin = new Thickness(5);
            //----------------------------------
            mainContainer.Children.Add(name);
            mainContainer.Children.Add(input);
        }

        public override StackPanel Result()
        {
            return mainContainer;
        }
    }
}
