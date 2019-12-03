using System;
using System.Collections.Generic;
using System.Text;

namespace задание_10_лаба_15
{
    class Person
    {
        public string Name { get; set; }

        public string SecondName { get; set; }

        public int GroupName { get; set; }

        public Person(string name, string secondName, int groupName)
        {
            Name = name;
            SecondName = secondName;
            GroupName = groupName;
        }
    }
}
