using System;
using System.Collections.Generic;
using System.Text;

namespace _0_задание_9_лаба
{
    class Box<T>
    {
        public T SomeProps { get; set; }

        public Box(T someValue) => SomeProps = someValue;

        public override string ToString()
        {
            StringBuilder stringBuilde = new StringBuilder();
            stringBuilde.Append(SomeProps.GetType().FullName + $" - {SomeProps}");

            return stringBuilde.ToString();
        }
    }
}
