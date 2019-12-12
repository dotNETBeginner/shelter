using System;

namespace задание_3_лаба_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();

            string[] sEmail = email.Split("@");

            string replacmentString = null;

            for(int i = 0; i < sEmail[0].Length; i++)
            { replacmentString += '*'; }

            sEmail[0] = replacmentString;

            string t = null;

            t += $"{sEmail[0]}@{sEmail[1]}";

            string[] c = Console.ReadLine().Split(" ");

            for(int i = 0; i < c.Length; i++)
            {
                if (c[i] == email)
                { c[i] = t; }
            }

            for(int i = 0; i < c.Length; i++)
            { Console.Write($"{c[i]} "); }

            //char[] cc = new char[c.Length];

            //for (int i = 0; i < c.Length; i++)
            //{ cc[i] = c[i]; }

            //int j = 0;

            //for(int i = 0; i < cc.Length;i++)
            //{
            //        if (cc[i] == email[j])
            //        {
            //            cc[i] = '*';
            //            j++;
                      
            //        }
            //}

            //for(int i = 0; i < cc.Length; i++)
            //{ Console.Write(cc[i]); }

        }
    }
}
