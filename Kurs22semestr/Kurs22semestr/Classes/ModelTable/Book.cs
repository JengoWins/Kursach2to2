using Kurs22semestr.Classes.ModelTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Classes
{
    class Book: Towar
    {
        protected string Autor;
        protected int Pages;

        public Book() {}
        public Book(string names, string discrip, string autor, int pages, int prices)
        {
            name = names;
            Autor = autor;
            discript = discrip;
            Pages = pages;
            price = prices;
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string Articul
        {
            get { return articul; }
            set { articul = value; }
        }
        public override string Discript
        {
            get { return discript; }
            set { discript = value; }
        }
        public override int Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
