using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5__лаба_7_
{
    class Rebel : IBuyer
    {
       public string Name { get; set; }
       public int Age { get; set; }
       public string GroupName { get; set; }
       public int Food { get; set; }

        public Rebel(string name, int age, string groupName)
        {
            Name = name;
            Age = age;
            GroupName = groupName;
            Food = 0;
        }

        public void BuyFood() => Food += 5;
    }
}
