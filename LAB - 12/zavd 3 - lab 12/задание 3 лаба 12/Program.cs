using System;

namespace задание_3_лаба_121
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimitiveCalculator somePrimitiveCalculator = new PrimitiveCalculator();

            string[] command = { "" };

            while(command[0] != "END")
            {
                command = Console.ReadLine().Split(" ");

                if(command.Length == 2)
                {
                    if(command[0] == "mode")
                    { somePrimitiveCalculator.ChangeStrategy(command[1][0]); }
                    else
                    { somePrimitiveCalculator.PerformCalculation(int.Parse(command[0]),int.Parse(command[1])); }
                } 
            }
        }
    }
}
