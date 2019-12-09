using System;

namespace Задание_1_лаба_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            Handler someHandler = new Handler();
            Dispatcher someDispatcher = new Dispatcher(command, someHandler);

            while (command != "END")
            {
                command = Console.ReadLine();
                
                if(command != "END")
                { someDispatcher = new Dispatcher(command, someHandler); }
            }
        }
    }
}
