using System;

namespace _0_задание_9_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> someBox = new Box<int>(200);

            Console.WriteLine(someBox.ToString());

            Console.Read();
        }
    }
}
