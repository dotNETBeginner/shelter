using System;

namespace Задание_2_лаба_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k; //Создаём переменные для розмерности массива, и количества вращений массива

            Console.WriteLine("Введите количество вращений массива.");
            k = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Введите данные в массив.");

            string arrayS;       
            arrayS = Console.ReadLine();
            string[] array1 = arrayS.Split(" ");  //Создаем строчный массив array1, он будет равен элементам строчной переменной arrayS(Мы разбили переменную почленно)

            int[] array = new int[arrayS.Length]; //создаем наш основной массив
             n = array1.Length; //размерность нашего массива 
            for (int i = 0; i < array1.Length; i++) //Цикл для заполнений главного массива
                array[i] = Convert.ToInt32(array1[i]); // array[i] равен конвертированому в int значение array1[i] 

            int[] sumArray = new int[n]; //Создаем массив для суммы

             
            for(int j = 0;j<k;j++) //Вращение массива
            {
                int t = array[n-1]; //Создадим переменную которая будет хранить значение последнего элемента
                for (int i = n - 1; i > 0; i--) { array[i] = array[i - 1]; } //То есть например элемент array[3] займет место array[2] и наоборот
                    array[0] = t; //Передаём значение последнего элемента первому, так как после исполнения строки 31, последний элемента бы не было, но мы его заранее сохранили
                    for(int p = 0; p < n; p++) { sumArray[p] += array[p]; } //Записываем сумму в наш массив
                

            }
            Console.WriteLine("Результат");
            for (int i = 0; i < n; i++) { Console.Write(sumArray[i] + " "); }
        }
    }
}
