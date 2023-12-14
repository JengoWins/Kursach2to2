using Kurs22semestr.Classes.ResultData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Kurs22semestr.Classes.InsertData
{
    internal class BlockInput: Container2, InterfaseInputs
    {
        public BlockInput()
        {
            mainContainer = new StackPanel();
            name = new TextBlock();
            input = new TextBox();
        }

        public string Output { get { return input.Text; } }

        public void SettingName(string n)
        {
            name.Text = n;
            name.Width = 150;
            name.Height = 100;
            name.FontSize = 18;
            name.TextWrapping = TextWrapping.Wrap;
            input.Margin = new Thickness(10, 0, 10, 0);
        }
        public void SettingInput()
        {
            input.Width = 100;
            input.Height = 100;
            input.FontSize = 18;
            input.TextWrapping = TextWrapping.Wrap;
            input.Margin = new Thickness(5,0,5,0);
        }

        public void SettingStack()
        {
            input.Width = 600;
            //---------------------------------
            mainContainer.Orientation = Orientation.Horizontal;
            mainContainer.Margin = new Thickness(5);
            //----------------------------------
            mainContainer.Children.Add(name);
            mainContainer.Children.Add(input);
        }

        public StackPanel Result()
        {
            return mainContainer;
        }
    }
}
