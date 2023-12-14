using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs22semestr.Classes.ModelTable
{
    class Technical : Towar
    {
        private string series;
        private string system;
        private int core;
        private int storeg;
        private int years;
        public Technical() { }
        public Technical(string n, string a, string d,string ser,string sys,int c, int store,int year) {
             
        }


        public override string Name {
            get{return name;}
            set{name = value;}
        }
        public override string Articul {
            get { return articul; }
            set { articul = value; }
        }
        public override string Discript {
            get { return discript; }
            set { discript = value; }
        }
        public override int Price {
            get { return price; }
            set { price = value; }
        }
    }
}
