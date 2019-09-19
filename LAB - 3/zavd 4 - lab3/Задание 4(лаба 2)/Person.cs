using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_2_
{
    class Person
    {
        private string name;
        private int age;

        public string Name { get; set; }
        public int Age { get; set; }


        public Person()
        {
            Name = "Noname";
            Age = 1;
        }
        public Person(int Age)
        {
            Name = "Noname";
            this.Age = Age;
        }
        public Person(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public void printInfo()
        {
            Console.WriteLine($"{Name} {Age}");
        }

       
    }
}
