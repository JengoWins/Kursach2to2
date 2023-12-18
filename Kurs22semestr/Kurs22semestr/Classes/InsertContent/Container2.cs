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
    abstract class Container2
    {
        protected StackPanel mainContainer;
        protected TextBlock name;
        protected TextBox input;
        abstract public string Output { get; }

        public Container2()
        {
        }

        abstract public void SettingName(string n);
        abstract public void SettingInput();
        abstract public void SettingStack();
        abstract public StackPanel Result();
    }
}
