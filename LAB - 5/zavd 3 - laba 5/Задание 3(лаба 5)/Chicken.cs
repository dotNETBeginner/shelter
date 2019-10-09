using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3_лаба_5_
{
    class Chicken
    {
        private string name;
        private int age;

        public string Name 
        {
            get { return name; }
            set 
            {
                if(value == "" || value == " ") { Console.WriteLine("Имя не может быть пустым"); }
                else { name = value; }
            }
        }
        public int Age 
        {
            get { return age; }
            set
            {
                if(value <= 0 || value > 15) {Console.WriteLine("Возраст должен быть в диапазоне от 0 до 15"); }
                else { age = value; }
            }
        }

        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void printInfo()
        {
            if(Name == null || Age == 0) { Environment.Exit(0); }
            else
            {
                Console.WriteLine($"Курица {name} может производить 1 яйцо на день.");
            }
        }
    }
}
