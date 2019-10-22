using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_2_лаба_6_
{
    public class Book
    {
        private string author;
        private string title;
        private float price;

        public string Author
        {
            get { return author; }
            set
            {
                string[] someValue = value.Split(" ");
                string someWord = someValue[1];
                bool isDigit=false;

                for (int i=0;i<someWord.Length;i++)
                {
                    isDigit = char.IsDigit(someWord[i]);
                    if (isDigit) { break; }
                }

                if(isDigit)
                { throw new ArgumentException("Author not valid!"); }
                else { author = value; }
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                if(value.Length < 3)
                { throw new ArgumentException("Title not valid!"); }
                else { title = value; }
            }
        }

        public float Price
        {
            get { return price; }
            set
            {
                if(value < 0 || value == 0)
                { throw new ArgumentException("Price not valid!"); }
                else { price = value; }
            }
        }

        public Book(string author,string title,float price)
        {
            Author = author;
            Title = title;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder someString = new StringBuilder();
            someString.Append($"Type: {GetType().Name}\nTitle: {Title}\nAuthor: {Author}\nPrice: {Price.ToString("0.00")}");

            return someString.ToString();
        }
    }
}
