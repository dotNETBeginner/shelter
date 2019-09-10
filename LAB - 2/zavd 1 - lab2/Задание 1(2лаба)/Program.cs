using System;

namespace Задание_1_2лаба_
{
    class Program
    {
        static void Main(string[] args)
        {
            string words1, words2;  //Инициализация переменніых для наших предложений
            Console.WriteLine("Введите первое предложение");
            words1 = Console.ReadLine();
            string[] s1 = words1.Split(' ');  //С помощью метода Split мы пословно разбили переменную s1 на массив

            Console.WriteLine("Введите первое предложение");
            words2 = Console.ReadLine();
            string[] s2 = words2.Split(' '); //Смотреть строку под номером 12
            
            int count = 0; //Создаем переменную для того чтобы подсчитать количество одинаковых слов
            if (s1.Length <= s2.Length) //Если первое предложение меньше второго, или они равны то будет выполнен следующий цикл 
            {
                for (int i = 0; i < s1.Length; i++) 
                {
                    if (s1[i] == s2[i]) { count++; Console.Write(s1[i] + " "); } //Если выполняется условие равности то счётчик слов возрастёт на 1, и эти слова будут показаны на экране
                 }
            }
            else //Если второе предложение меньше первого
            {
                for (int i = s2.Length - 1; i >= 0; i--) //Начинаем с конца второго предложения и заканчиваем на его начале
                {
                    for (int j = s1.Length - 1; j >= (s1.Length - s2.Length); j--) //Начинаем с конца первого предложения но заканчиваем мы не в начале
                    {
                        if (s1[j] == s2[i]) { count++; Console.Write(s2[i] + " "); } //Смотреть строку под номером 23

                    }
                }
            }
                Console.WriteLine();
                Console.WriteLine($"Количество - {count}"); //Выводим результат
        }
    }
}
