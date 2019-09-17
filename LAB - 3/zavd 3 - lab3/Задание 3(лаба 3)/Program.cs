using System;

namespace Задание_3_лаба_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество членов семьи.");
            int n;
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ведите имя и возраст членов семьи.");
            int[] ages = new int[n];
            string[] names = new string[n];

            Family fam1=new Family(n);

            for(int i=0;i<n;i++)
            {
                names[i] = Console.ReadLine();
                ages[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0;i<n;i++)
            {
                fam1.addMember(i,names,ages);
            }

            fam1.printInfo();
            
                fam1.getOldestMember(n);
            
        }
    }
}
