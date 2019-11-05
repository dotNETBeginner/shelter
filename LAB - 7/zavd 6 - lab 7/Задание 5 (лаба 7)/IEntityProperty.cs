using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5__лаба_7_
{
    interface IEntityProperty
    {
        public string Name { get; set; }
        public string BirthDate { get; set; }

        public void FindYearInDate(string year);
    }
}
