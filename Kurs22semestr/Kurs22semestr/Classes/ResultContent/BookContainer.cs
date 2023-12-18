using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using Kurs22semestr.Classes.BD.DeleteBD;

namespace Kurs22semestr.Classes.ResultData
{
    class BookContainer: Container, InterfaseBookC
    {
        private TextBlock pages;
        private TextBlock author;
        private Border br;
        private Button RemoveBut;
        public BookContainer()
        {
            mainContainer = new StackPanel();
            name = new TextBlock();
            articul = new TextBlock();
            discript = new TextBlock();
            price = new TextBlock();
            pages = new TextBlock();
            author = new TextBlock();
            br = new Border();
            RemoveBut = new Button();
            SettingBut();
        }

        private void SettingBut()
        {
            RemoveBut.Background = Brushes.Red;
            RemoveBut.Width = 100;
            RemoveBut.Height = 25;
            RemoveBut.Content = "Удалить";
            RemoveBut.Click += Delete;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            BDDeleteBook del = new BDDeleteBook();
            del.BdConnsOpen();
            del.DeleteBookWare(articul.Text);
            del.DeleteBook(articul.Text);
            del.DeleteBase(articul.Text);
            del.BdConnsExit();
            MessageBox.Show("Вы удалили запись");
        }
        public void SettingName(string n)
        {
            name.Text = n;
            name.Width = 200;
            name.Height = 100;
            name.FontSize = 18;
            name.TextWrapping = TextWrapping.Wrap;
            name.Margin = new Thickness(0);
        }
        public void SettingArticul(string n)
        {
            articul.Text = n;
            articul.Width = 150;
            articul.Height = 100;
            articul.FontSize = 18;
            articul.TextWrapping = TextWrapping.Wrap;
            articul.Margin = new Thickness(0);
        }
        public void SettingDiscript(string n)
        {
            discript.Text = n;
            discript.Width = 300;
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
            pages.Width = 150;
            pages.Height = 100;
            pages.FontSize = 18;
            pages.TextWrapping = TextWrapping.Wrap;
            pages.Margin = new Thickness(0);
        }

        public void SettingAuthor(string n)
        {
            author.Text = n;
            author.Width = 150;
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
            mainContainer.Children.Add(RemoveBut);
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
