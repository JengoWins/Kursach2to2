using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kurs22semestr.Classes.InsertData
{

        interface InterfaseInput
        {
            public string Output { get; }
            public void SettingName();
            public void SettingInput();
            public void SettingStack();
            public StackPanel Result();
        }

        interface InterfaseInputs
        {
            public void SettingName();
            public void SettingInput();
            public void SettingStack();
            public StackPanel Result();
        }
       
}
