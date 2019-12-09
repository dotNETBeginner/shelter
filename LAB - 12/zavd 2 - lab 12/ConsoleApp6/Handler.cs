using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Handler //Класс обработчика событий
    {
        public Handler() { } //пустой конструктор так как в классе оглашен только метод

        public void RoyalHandler(object sender, RoyalEventArgs args) 
        {
            if(sender.GetType().FullName == "ConsoleApp6.King") //Если тип отправщика Король, то будет выводится специальное сообщение для события Короля
            { Console.WriteLine($"King {args.Name} is under attack!"); }

            else if(sender.GetType().FullName == "ConsoleApp6.RoyalGuard") //Если тип отправщика охранник, то будет выводится специальное сообщение для события охранника
            { Console.WriteLine($"Royal Guard {args.Name} is defending!"); }

            else if (sender.GetType().FullName == "ConsoleApp6.Footman") //Если тип отправщика Шут, то будет выводится специальное сообщение для события шута
            { Console.WriteLine($"Footman {args.Name} is panicking!"); }
        }
    }
}
