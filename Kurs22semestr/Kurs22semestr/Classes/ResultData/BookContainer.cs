using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Kurs22semestr.Classes.ResultData
{
    class BookContainer: Container, InterfaseBookC
    {
        private TextBlock pages;
        private TextBlock author;
        public BookContainer()
        {
            mainContainer = new StackPanel();
            name = new TextBlock();
            articul = new TextBlock();
            discript = new TextBlock();
            price = new TextBlock();
            pages = new TextBlock();
            author = new TextBlock();
        }

        public void SettingName(string n)
        {
            name.Text = n;
            name.Width = 100;
            name.Height = 100;
            name.FontSize = 18;
            name.TextWrapping = TextWrapping.Wrap;
            name.Margin = new Thickness(0);
        }
        public void SettingArticul(string n)
        {
            articul.Text = n;
            articul.Width = 100;
            articul.Height = 100;
            articul.FontSize = 18;
            articul.TextWrapping = TextWrapping.Wrap;
            articul.Margin = new Thickness(0);
        }
        public void SettingDiscript(string n)
        {
            discript.Text = n;
            discript.Width = 100;
            discript.Height = 100;
            discript.FontSize = 18;
            discript.TextWrapping = TextWrapping.Wrap;
            discript.Margin = new Thickness(0);
        }
        public void SettingPrice(string n)
        {
            price.Text = n;
            price.Width = 100;
            price.Height = 100;
            price.FontSize = 18;
            price.TextWrapping = TextWrapping.Wrap;
            price.Margin = new Thickness(0);
        }

        public void SettingPages(string n)
        {
            pages.Text = n;
            pages.Width = 100;
            pages.Height = 100;
            pages.FontSize = 18;
            pages.TextWrapping = TextWrapping.Wrap;
            pages.Margin = new Thickness(0);
        }

        public void SettingAuthor(string n)
        {
            author.Text = n;
            author.Width = 100;
            author.Height = 100;
            author.FontSize = 18;
            author.TextWrapping = TextWrapping.Wrap;
            author.Margin = new Thickness(0);
        }

        public void SettingStack()
        {
            //---------------------------------
            mainContainer.Orientation = Orientation.Horizontal;
            mainContainer.Margin = new Thickness(0);
            //----------------------------------
            mainContainer.Children.Add(name);
            mainContainer.Children.Add(articul);
            mainContainer.Children.Add(discript);
            mainContainer.Children.Add(price);
            mainContainer.Children.Add(author);
            mainContainer.Children.Add(pages);
        }

        public StackPanel Result()
        {
            return mainContainer;
        }
    }
}
