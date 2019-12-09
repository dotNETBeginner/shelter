using System;
using System.Collections.Generic;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<King> someKing = new List<King>();
            List<RoyalGuard> someRoyalGuards = new List<RoyalGuard>();   //Охрана
            List<Footman> someFootmans = new List<Footman>();            //Шуты

            string[] command = { "" };

            for(int i = 0; i < 3; i++) // Цикл для ввода имени Короля, Охранников, Шутов
            {
                command = Console.ReadLine().Split(" "); 

                List<string> someCommand = new List<string>(); //Создаем лист чтобы было легче удалять одинаковые элементы

                for(int j = 0; j < command.Length; j++) 
                { someCommand.Add(command[j]); }

                for (int j = 0; j < someCommand.Count; j++)
                {
                    for (int q = 0; q < someCommand.Count; q++)
                    {
                        if (q != j)
                        {
                            if (someCommand[q] == someCommand[j])                //Удаление дубликантов
                            { someCommand.Remove(someCommand[q]); }
                        }
                    }
                }

                if (i == 0)                      //Первым всегда вводится Король
                {
                    if(command.Length == 1)
                    { someKing.Add(new King(command[0])); }
                }

                if(i == 1 || i == 2)         //Вторым - Охранники, Третьими - Шуты
                {
                    if(command.Length > 0) //Должен быть хотя бы один Охранник и Шут
                    {
                        for (int j = 0; j < someCommand.Count; j++)
                        {
                            if (i == 1)                   //Если второй ввод то будут добавлятся Охранники
                            { someRoyalGuards.Add(new RoyalGuard(someCommand[j])); }

                            if (i == 2)                   //Если третий ввод то будут добавлятся Шуты
                            { someFootmans.Add(new Footman(someCommand[j])); }
                        }
                    }
                }

            }

            
            while(command[0] != "END")  //Пока в консоль не будет введена команда "END"
            {
                command = Console.ReadLine().Split(" ");

                if(command.Length == 2)  
                {
                    if(command[0] == "Attack")   //Если введена команда "Attack"
                    { 
                        someKing[0].KingWasAttacked(new RoyalEventArgs(someKing[0].Name)); //Вызывается событие "King <Name> is under attack!"

                        for (int i = 0; i < someRoyalGuards.Count; i++)
                        { someRoyalGuards[i].KingWasAttacked(new RoyalEventArgs(someRoyalGuards[i].Name)); } //Вызывается событие "Royal Guard <Name> is defending!"

                        for (int i = 0; i < someFootmans.Count; i++)
                        { someFootmans[i].KingWasAttacked(new RoyalEventArgs(someFootmans[i].Name)); }  //Вызывается событие "Footman <Name> is panicking!"
                    }

                    else if(command[0] == "Kill") //Если введена команда "Kill"
                    {
                        for(int i = 0; i < someRoyalGuards.Count; i++) //Ищет в стражниках если имя того кого надо убить есть в этом списке
                        {
                            if(someRoyalGuards[i].Name == command[1])
                            { someRoyalGuards.Remove(someRoyalGuards[i]); }
                        }

                        for (int i = 0; i < someFootmans.Count; i++) //Ищет в шутах если имя того кого надо убить есть в этом списке
                        {
                            if (someFootmans[i].Name == command[1])
                            { someFootmans.Remove(someFootmans[i]); }
                        }
                    }
                }
            }

        }
    }
}
