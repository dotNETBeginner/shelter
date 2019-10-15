using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_2_лаба_6_
{
    class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author,string title,float price)
            :base(author,title,price)
        {
            float percent = (price * 30) / 100;
            base.Price = price + percent;
        }
    }
}
