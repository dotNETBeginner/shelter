using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5__лаба_7_
{
    class Pet : IEntityProperty
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }

        public Pet(string name, string birthdate)
        {
            Name = name;
            BirthDate = birthdate;
        }

        public void FindYearInDate(string year)
        {
            string[] sB = BirthDate.Split("/");

            if(sB[2] == year) { Console.WriteLine(BirthDate); }
        }
    }
}
