using System;
using System.Collections.Generic;
using System.Text;

namespace _2_задание_8_лаба
{
    class Dog : Animal
    {
        public Dog(string name, string favouriteFood) : base(name, favouriteFood) { }

        public override void ExplainSelf()
        {
            base.ExplainSelf();
            Console.WriteLine("DJAAF");
        }
    }
}
