using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Kurs22semestr.Classes.ResultData
{
    class Container
    {
        protected StackPanel mainContainer;
        protected TextBlock name;
        protected TextBlock articul;
        protected TextBlock discript;
        protected TextBlock price;
        public Container() { 
            mainContainer = new StackPanel();
            name = new TextBlock();
            articul = new TextBlock();
            discript = new TextBlock();
            price = new TextBlock();
        }

        public void SettingName()
        {
        }
        public void SettingArticul()
        {
        }
        public void SettingDiscript()
        {
        }
        public void SettingPrice()
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
