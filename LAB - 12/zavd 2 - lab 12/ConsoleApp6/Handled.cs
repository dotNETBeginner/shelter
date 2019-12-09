using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
     abstract class Handled //Абстрактный класс как набор свойств для всех остальных классов
    {
        public Handler someHandler; //Обьект класа обработчика

        public event RoyalHandler RoyalEvent; //Событие типа нашого делегата

        public void KingWasAttacked(RoyalEventArgs args) //Метод который активирует Событие
        { RoyalEvent.Invoke(this, args); }
    }
}
