using System;
using System.Collections;
using System.Collections.Generic;

namespace Задание_9_лаба_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во прямоугольников");
            int n = int.Parse(Console.ReadLine());

            List<Rectangle> square=new List<Rectangle>();

            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(" ");
              Rectangle t=new Rectangle(s[0],int.Parse(s[1]),int.Parse(s[2]),int.Parse(s[3]),int.Parse(s[4]));
                square.Add(t);
            }
            bool notExist1 = false;
            bool notExist2 = false;
            string command1 = " ";
            while(command1!="End")
            {
          
                int indx1 = 0;
                int indx2 = 0;
                Console.WriteLine("Введите два прямоугольника которые хотите сравнить, или команду выхода *End*");
                command1 = Console.ReadLine();
                string[] command2 = command1.Split(" ");
                if(command2.Length>2)
                {
                    Console.WriteLine("Слишком много аргументов!");
                }
                else if(command2.Length==2)
                {
                    for(int i=0;i<n;i++)
                    {
                        if (command2[0] == square[i].Id) { indx1 = i; notExist1 = false; break; }
                        else if (command2[0] != square[i].Id) {notExist1 = true;  }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        if (command2[1] == square[i].Id) { indx2 = i; notExist2 = false; break; }
                        else if (command2[1] != square[i].Id) { notExist2 = true;  }
                    }
                    if (!notExist1 && !notExist2) { square[indx1].findTouch(square[indx2]); }
                    else if (notExist1 && notExist2){ Console.WriteLine("Таких фигур не сущевствует."); }
                    else if(notExist1 && !notExist2|| !notExist1 && notExist2) { Console.WriteLine("Один из аргументов введён неправильно!"); }
                }
            }
           
        }
    }
}
