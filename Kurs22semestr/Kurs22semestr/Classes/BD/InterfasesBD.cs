using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs22semestr.Classes
{

    interface InterfasesBDSelect
    {
        public void BdConnsOpen();

        public void BdConnsExit();
    }

    interface InterfasesBDBook
    {
        public void BdConnsOpen();
        public void InsertBase(string name, string articul, string discript, int price);
        public void InsertBook(string author, int pages, string name);
        public void BdConnsExit();
    }
    interface InterfasesBDWareBook
    {
        public void BdConnsOpen();
        public void InsertBook(int count, int zone, string emp, string towar);
        public void BdConnsExit();
    }
    interface InterfasesBDTech
    {
        public void BdConnsOpen();
        public void InsertBase(string name, string articul, string discript, int price);
        public void InsertTechical(string series, string systems, int core, int store, int year, string name);
        public void BdConnsExit();
    }
    interface InterfasesBDWareTech
    {
        public void BdConnsOpen();
        public void InsertTechical(int count, int zone, string emp, string towar);
        public void BdConnsExit();
    }
}
