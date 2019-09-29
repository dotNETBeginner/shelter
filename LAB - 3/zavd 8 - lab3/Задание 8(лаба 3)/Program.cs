using System;
using System.Collections;
using System.Collections.Generic;
namespace Задание_8_лаба_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во автомобилей");
            int n = int.Parse(Console.ReadLine());

            List<Tires> group = new List<Tires>();

            for(int i=0;i<n;i++)
            {
                string s1 = Console.ReadLine();
                string[] s2 = s1.Split(" ");
                Tires t = new Tires(s2[0], int.Parse(s2[1]), int.Parse(s2[2]), int.Parse(s2[3]), s2[4], Convert.ToDouble(s2[5]), int.Parse(s2[6]), double.Parse(s2[7]), int.Parse(s2[8]),
                    double.Parse(s2[9]), int.Parse(s2[10]), double.Parse(s2[11]), int.Parse(s2[12]));
                group.Add(t);
            }
            Console.WriteLine("Введите тип груза");
            string type = Console.ReadLine();
            for(int i=0;i<n;i++)
            {
                if(type==group[i].CargoType)
                {
                    if(group[i].CargoType == "fragile")
                    {
                        if (group[i].findAllPressureValue() < 1) {Console.WriteLine(group[i].Model); }
                    }
                    if (group[i].CargoType == "flamable")
                    {
                        if (group[i].EnginePower > 250) { Console.WriteLine(group[i].Model); }
                    }
                }
                else
                {
                    Console.WriteLine("Такиз типов груза нету.");
                }
            }
        }
    }
}
