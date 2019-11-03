using System;
using System.Collections.Generic;
using System.Text;

namespace задание_10_лаба_7
{
    class Citizen : IPerson,IResident
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        public Citizen(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }

        void IResident.GetName() => Console.WriteLine($"Mr/Ms/Mrs {Name}");

        void IPerson.GetName() => Console.WriteLine(Name);

        public void Display()
        {
            Citizen t = new Citizen(Name, Country, Age);
            IPerson link1 = (IPerson)t;
            link1.GetName();
            IResident link2 = (IResident)t;
            link2.GetName();
        }

    }
}
