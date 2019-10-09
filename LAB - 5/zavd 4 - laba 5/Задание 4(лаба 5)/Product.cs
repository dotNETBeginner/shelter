using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_5_
{
    class Product
    {
        private string productName;

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (value == "" || value == " ") { productName = null; }
                else { productName = value; }
            }
        }
        public int ProductPrice { get; set; }

        public Product() { }

        public Product(int i, string[] s)
        {
            ProductName = s[i];
            ProductPrice = int.Parse(s[i + 1]);
        }

        public Product(string name,int price)
        {
            ProductName = name;
            ProductPrice = price;
        }
    }
}
