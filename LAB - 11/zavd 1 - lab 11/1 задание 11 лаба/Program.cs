using System;

namespace _1_задание_11_лаба
{
    class Program
    {
        static void Main(string[] args)
        {
            RichSoilLand someLand = new RichSoilLand();

            string command = "";

            while(command != "HARVEST")
            {
                command = Console.ReadLine();

                someLand.DisplayInfo(command);
            }
        }
    }
}
