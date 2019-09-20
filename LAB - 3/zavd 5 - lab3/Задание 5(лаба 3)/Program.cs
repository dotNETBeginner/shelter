using System;

namespace Задание_5_лаба_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую дату. (Год_Месяц_День)");
            string date1=Console.ReadLine();
            string[] Date1 = date1.Split(" ");

            Console.WriteLine("Введите вторую дату. (Год_Месяц_День)");
            string date2=Console.ReadLine();
            string[] Date2 = date2.Split(" ");

            DateModifier dateSum = new DateModifier();

            dateSum.findDifOfTwoDates(Date1,Date2);
        }
    }
}
