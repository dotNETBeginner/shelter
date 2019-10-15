using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_1_лаба_6_
{
    class Child : Person
    {
        public override int Age
        {
            get { return base.Age; }
            set
            {
                if(value > 15)
                { throw new ArgumentException("Child`s age must be less than 15!"); }
                else { base.Age = value; }
            }
        }

        public Child(string name,int age)
            :base(name,age)
        {
        }
    }
}
