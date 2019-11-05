using System;

namespace Задание_4__лаба_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("В первой строке введите номера телефонов, во второй строке введите url-адреса");
            string[] sPhoneNumbers = Console.ReadLine().Split(" ");
            string[] sUrl = Console.ReadLine().Split(" ");

            Smartphone someSmartphone = new Smartphone();
            someSmartphone.Notify += (sea) => Console.WriteLine(sea.Message);
            
            for(int i=0;i<sPhoneNumbers.Length;i++)
            { someSmartphone.Call(sPhoneNumbers[i]); }

            for (int i = 0; i < sUrl.Length; i++)
            { someSmartphone.Browse(sUrl[i]); }
        }
    }
}
