using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs22semestr.Classes.ModelTable
{
    abstract class Towar
    {
        protected string name;
        protected string articul;
        protected string discript;
        protected int price;
        protected Towar() { }
        protected Towar(string n,string a,string d) { }

        public abstract string Name { get; set; }
        public abstract string Articul { get; set; }
        public abstract string Discript { get; set; }
        public abstract int Price { get; set; }
    }
}
