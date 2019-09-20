using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5_лаба_3_
{
    class DateModifier
    {
        private int dif;

        public int Dif { get; set; }

        public DateModifier() { }

        public void findMoon(int i,ref int d,int date)
        {

            if (i == 10 || i == 8||i % 2 != 0) { d = 31; }
                if (i % 2 == 0)
            {
                if (i != 10 && i != 8 && i != 2) { d = 30; }
            }
            if (i == 2) { if (date % 4 == 0) { d = 28; } else { d = 29; } }
        }

        public void findDifOfTwoDates(string[] date1, string[] date2)
        {
            int k=1,m,d1=0,d2=0,d=0,day=0,dateBig=0,dateSmall=0;
            int[] dateInt1 = new int[date1.Length];
            int[] dateInt2 = new int[date2.Length];
            for (int i = 0; i < dateInt1.Length; i++) {dateInt1[i]=Convert.ToInt32(date1[i]); }

            for (int i = 0; i < dateInt2.Length; i++) { dateInt2[i] = Convert.ToInt32(date2[i]); }

            //Код для поиска разницы дней (Считает разницу только в годах)
            if (dateInt1[0]> dateInt2[0])
                {
                    for(int j = dateInt2[0]; j< dateInt1[0]; j++)
                    {
                        if (j % 4 == 0) {Dif += 365 + k; } //Проверка - високосный ли год
                        else {Dif+=365; }
                    }
                }
                else if (dateInt1[0] < dateInt2[0])
                {
                    for (int j = dateInt1[0]; j < dateInt2[0]; j++)
                    {
                    if (j % 4 == 0) {Dif += 365+k; }  //Проверка - високосный ли год
                    else { Dif += 365; }
                    }
                }
                else {Dif=+0; }
            //
            //
            findMoon(dateInt1[1],ref d1,dateInt1[0]);
      
            findMoon(dateInt2[1], ref d2, dateInt2[0]);

            if(dateInt1[2]> dateInt2[2]) { day = dateInt1[2] - dateInt2[2]; }
            if(dateInt2[2] > dateInt1[2]) { day = dateInt2[2] - dateInt1[2]; }

            if (dateInt1[0] > dateInt2[0]) { dateBig = dateInt1[0]; dateSmall = dateInt2[0]; }
            else if(dateInt1[0] < dateInt2[0]) { dateBig = dateInt2[0]; dateSmall = dateInt1[0]; }



                if (dateInt1[1] > dateInt2[1])
                {
                    m = dateInt1[1] - dateInt2[1];
                    if(m>1)
                    {
                        for (int i = dateInt2[1]; i < dateInt1[1]; i++) //*****1
                        {
                            findMoon(i, ref d, dateBig);
                            if(i!= dateInt1[1] - 1) { Dif += d; }
                            if (i == dateInt1[1] - 1) {Dif+=((d - dateInt2[2]) + dateInt1[2]); ; }
                        }
                    }
                    else
                    {
                        findMoon(dateInt2[1], ref d, dateBig);
                        Dif += (d-dateInt2[2])+dateInt1[2];
                    }
                }
                else if (dateInt1[1] < dateInt2[1])
                {

                    m = dateInt2[1] - dateInt1[1];
                    if (m > 1)
                    {
                        for (int i = dateInt1[1]; i < dateInt2[1]; i++) //*****1
                        {
                            findMoon(i, ref d, dateBig);
                            if (i != dateInt2[1] - 1) { Dif += d; }
                            if (i == dateInt2[1] - 1) { Dif += ((d - dateInt1[2]) + dateInt2[2]) ; }
                        }
                    }
                    else
                    {
                        findMoon(dateInt1[1], ref d, dateBig);
                        Dif += (d - dateInt1[2]) + dateInt2[2];
                    }

                }
               
            
            else
            {
                if (dateInt1[1] > dateInt2[1]) { findMoon(dateInt2[1], ref d, dateInt1[0]); Dif += ((d - dateInt2[2]) + dateInt1[2]); }
                    if (dateInt1[1] < dateInt2[1]) { findMoon(dateInt1[1], ref d, dateInt2[0]); Dif += ((d - dateInt1[2]) + dateInt2[2]); }
            }
            Console.WriteLine($"Разница между двумя датами - {Dif}");
        }
    }
}
