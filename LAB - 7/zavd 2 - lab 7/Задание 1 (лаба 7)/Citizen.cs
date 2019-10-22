using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1__лаба_7_
{
    class Citizen : IPerson,IIdentifiable,IBirthable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public string BirthDate { get; set; }

        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
        }

        public void Display() => Console.WriteLine($"{Name} is {Age} years old.\n" +
            $"{Id}  {BirthDate}");
        
    }
}
