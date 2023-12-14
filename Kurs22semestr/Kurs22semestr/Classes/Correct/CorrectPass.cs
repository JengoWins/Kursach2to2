using System;
using System.Windows;

namespace Kurs22semestr.Classes.Correct
{
    class CorrectPass
    {
        private string password; //Пароль
        public string Pass {
            get { return password; }
            //set {  password = value; }
        }
        public CorrectPass(string p) {
            password = p;
        }

        public bool CheckInInput()
        {
            bool isUpper = false; //Существует заглавная буква?
            bool isInt = false; //Существует число буква?
            bool complete = false; //Говорит о том, что все прошло успешно
            Console.WriteLine("Длина: " + password.Length);
            if (password.Length>=8) { //Введено минимум 8 символов?
                for (int i = 0; i < password.Length; i++)
                {
                    //Проверка на наличие большой буквы
                    if(CheckUpper(password[i]))
                        isUpper = true;
                    //Проверка на наличие числа
                    if (CheckInt(password[i]))
                        isInt = true;
                }
                if (isUpper && isInt) //Если число и заглавная буква существуют
                {
                    Console.WriteLine("Complete. Account access! ");
                    complete = true;
                }
                else
                {
                    Console.WriteLine("Incorrect. Not fount upper character or number in password!");
                    MessageBox.Show("Incorrect. Not fount upper character or number in password!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                Console.WriteLine("Incorrect. Minimum size password: 8 ");
                MessageBox.Show("Incorrect. Minimum size password: 8 ","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            return complete;
        }

        //Проверка заглавной
        public bool CheckUpper(char ch)
        {
            return char.IsUpper(ch);
        }
        //Проверка Числа
        public bool CheckInt(char ch) {  
            return char.IsDigit(ch); 
        }

    }
}
