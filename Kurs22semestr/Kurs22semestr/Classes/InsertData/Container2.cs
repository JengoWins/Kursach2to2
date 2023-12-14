using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Xml.Linq;

namespace Kurs22semestr.Classes.InsertData
{
    class Container2: InterfaseInput
    {
        protected StackPanel mainContainer;
        protected TextBlock name;
        protected TextBox input;
        public string Output { get; }

        public Container2()
        {
        }

        public void SettingName()
        {
        }
        public void SettingInput()
        {
        }

        public void SettingStack()
        {
        }

        public StackPanel Result()
        {
            return mainContainer;
        }
    }
}
