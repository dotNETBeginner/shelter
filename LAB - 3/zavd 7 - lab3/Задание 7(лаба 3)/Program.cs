using System;
using System.Collections;
using System.Collections.Generic;
namespace Задание_7_лаба_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество автомобилей.");
            int n = Int32.Parse(Console.ReadLine());

            List<Car> groupOfCars = new List<Car>();
            bool exist = false;
            for(int i=0;i<n;i++)
            {
                string s1 = Console.ReadLine();
                string[] s2 = s1.Split(" ");

                    for(int j=0;j<groupOfCars.Count;j++)
                    {
                        if (s2[0] == groupOfCars[j].Model)
                        {
                        exist = true;
                        Console.WriteLine("PUQUE");
                        }   //Проверка на модель
                    }
                if (exist) {n++; Console.WriteLine("Автомобиль с данной моделью уже существует.");}
                else
                {
                    Car t = new Car(s2[0],float.Parse(s2[1]),float.Parse(s2[2]));
                    groupOfCars.Add(t);
                }
                exist = false;
            }

            Console.WriteLine("Вы можете вводить команды. Есть только две команды -\n1.End - выход\n2.Drive <Модель автомобиля> <Дистанция>\n3.Клавиша Enter - очистка консоли\n4.P - Вывести все автомобили и их состояние");
            string command1 = "";
            Car temp = new Car();
            bool success2 = false;
            while (true)
            {
                command1 = Console.ReadLine();
                if (command1 != "")
                {
                    if (command1 == "End" || command1 == "end") { System.Environment.Exit(0); }
                    string[] command2 = command1.Split(" ");
                    int distance;
                    bool success1 = false;
                    if (command2.Length >= 2) { success1 = Int32.TryParse(command2[2], out distance); }
                    if (command2[0] == "Drive" || command2[0] == "drive")
                    {
                        for (int i = 0; i < groupOfCars.Count; i++)
                        {
                            if (command2[1] == groupOfCars[i].Model&& command2[1].Length== groupOfCars[i].Model.Length) { temp = groupOfCars[i]; success2=true;}
                            
                            }
                                if (success1&&success2)
                                {
                                    temp.CheckFuel(int.Parse(command2[2]));
                                }
                                else { Console.WriteLine("Данные были введены неправильно."); }
                    }
                     else if (command1 == "P" || command1 == "p")
                    {
                        for (int i = 0; i < groupOfCars.Count; i++) { groupOfCars[i].Display(); }
                    }
                    else { Console.WriteLine("Ошибка синтаксиса!"); }
                }
                else
                {
                    Console.Clear();
                     Console.WriteLine("Вы можете вводить команды. Есть только две команды -\n1.End - выход\n2.Drive <Модель автомобиля> <Дистанция>\n3.Клавиша Enter - очистка консоли\n4.P - Вывести все автомобили и их состояние");
                }

            }
        }
    }
}
