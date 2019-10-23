using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5__лаба_7_
{
    class Citizen : IIdentifiable,IEntityProperty
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }

        public Citizen(string name, int age, string id,string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
        }

        public void FindYearInDate(string year)
        {
            string[] sB = BirthDate.Split("/");

            if(sB[2] == year) { Console.WriteLine(BirthDate); }
        }
    }
}
