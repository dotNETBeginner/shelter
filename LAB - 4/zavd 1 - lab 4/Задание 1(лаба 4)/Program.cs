using System;
using System.Collections.Generic;
using System.Linq;

namespace Задание_1_лаба_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во авто");
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for(int i=0;i<n;i++)
            {
                string[] s1 = Console.ReadLine().Split(" ");
                Car t = new Car(s1[0],int.Parse(s1[1]), int.Parse(s1[2]), int.Parse(s1[3]), s1[4],
                    double.Parse(s1[5]), int.Parse(s1[6]), double.Parse(s1[7]), int.Parse(s1[8]), double.Parse(s1[9]), int.Parse(s1[10]), double.Parse(s1[11]), int.Parse(s1[12]));
                cars.Add(t);
            }
            Console.WriteLine("Введите тип груза");
            string type=Console.ReadLine();
            for(int i=0;i<n;i++)
            {
                if(type==cars[i].CargoType)
                {
                    if(cars[i].CargoType=="fragile"&& cars[i].fineAllTiresPressure() < 1) { Console.WriteLine(cars[i].Model); }
                    
                    if(cars[i].CargoType=="flamable"&&cars[i].EnginePower > 250) { Console.WriteLine(cars[i].Model); }
                }
                else {Console.WriteLine("Груза такого типа не существует"); }
            }
        }
    }
}
