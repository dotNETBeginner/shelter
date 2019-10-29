using System;
using System.Collections.Generic;
using System.Linq;

namespace Задание_4_лаба_4
{
    public class Program
    {
        public static void Main()
        {
            Hospital myHospital = new Hospital();

            string[] command = Console.ReadLine().Split(" ");

            while(command[0] != "Output")
            {
                 myHospital.Add(command[0], command[1], command[2], command[3]);

                command = Console.ReadLine().Split(" ");
            }

            while(command[0] != "End")
            {
                command = Console.ReadLine().Split(" ");
                if(command.Length == 1) { myHospital.DisplayPatients(command[0]); }
                else if(command.Length == 2) { myHospital.DisplayPatients(command[0],command[1]); }
            }
        }
    }
}