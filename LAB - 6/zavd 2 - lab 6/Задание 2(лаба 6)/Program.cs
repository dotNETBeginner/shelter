using System;

namespace Задание_2_лаба_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input author of book, title of book, and price of book");
                string authorOfBook = Console.ReadLine();
                string titleOfBook = Console.ReadLine();
                float priceOfBook = float.Parse(Console.ReadLine());

                Book someBook = new Book(authorOfBook, titleOfBook, priceOfBook);
                GoldenEditionBook someGoldenEditionBook = new GoldenEditionBook(authorOfBook, titleOfBook, priceOfBook);

                Console.WriteLine(someBook.ToString());
                Console.WriteLine();
                Console.WriteLine(someGoldenEditionBook.ToString());
            }
            catch (ArgumentException ae)
            { Console.WriteLine(ae.Message); }
        }
    }
}
