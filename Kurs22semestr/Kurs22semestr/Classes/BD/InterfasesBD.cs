using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs22semestr.Classes
{
    interface InterfasesBDConn
    {
        public void BdConnsOpen();
        public void BdConnsExit();
    }

    interface InterfasesBDSelect
    {
        public void BdConnsOpen();
        public void BdConnsExit();
    }
    interface InterfasesBDInsert
    {
        public void BdConnsOpen();
        public void BdConnsExit();
    }
}
