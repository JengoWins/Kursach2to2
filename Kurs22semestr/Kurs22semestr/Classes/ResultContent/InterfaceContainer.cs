using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kurs22semestr.Classes.ResultData
{
    interface InterfaseContainer
    {
        public void SettingName(string n);
        public void SettingArticul(string n);
        public void SettingDiscript(string n);
        public void SettingPrice(string n);
        public void SettingStack(string n);
        public StackPanel Result();
    }

    interface InterfaseTechnicalC
    {
        public void SettingName(string n);
        public void SettingArticul(string n);
        public void SettingDiscript(string n);
        public void SettingPrice(string n);
        public void SettingStack();
        public StackPanel Result();
    }
    interface InterfaseBookC
    {
        public void SettingName(string n);
        public void SettingArticul(string n);
        public void SettingDiscript(string n);
        public void SettingPrice(string n);
        public void SettingStack();
        public StackPanel Result();
    }
}
