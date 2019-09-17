using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3_лаба_3_
{
    class Person
    {
        private string name;
        private int age;


        public Person()
        {
            Name = "NoName";
            Age = 1;
        }

        public Person(int Age)
        {
            Name = "NoName";
            this.Age = Age;
        }

        public Person(int Age, string Name)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public void printInfo()
        {
            Console.WriteLine($"{Name} is {Age} years old.");
        }

    }
}
