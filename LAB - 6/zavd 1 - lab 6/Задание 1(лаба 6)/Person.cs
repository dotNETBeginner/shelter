using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1_лаба_6_
{
    public class Person
    {
        private string name;
        private int age;

        public virtual string Name
        {
            get { return name; }
            set
            {
                if(value.Length <= 3)
                { throw new ArgumentException("Name`s lenght should not be less than 3 symbols"); }
                else { name = value; }
            }
        }

        public virtual int Age
        {
            get { return age; }
            set
            {
                if(value < 0)
                { throw new ArgumentException("Age must be positive!"); }
                else { age = value; }
            }
        }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format($"{Name} is {Age} years old."));

            return stringBuilder.ToString(); 
        }
    }
}
