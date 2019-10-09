using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_4_лаба_5_
{
    class Person
    {
        private string name;
        public string Name 
        {
            get { return name; }
            set
            {
                if (value == "" || value == " ") { name = null; }
                else { name = value; }
            }
        }
        public int Money { get; set; }
       
        List<Product> BugOfproducts = new List<Product>();

        public Person(int i,string[] s)
        {
            Name = s[i];
            Money = int.Parse(s[i+1]);
        }
        
        public void addProductAtBug(Product someProduct)
        {
            if (Money >= someProduct.ProductPrice)
            {
                Money -= someProduct.ProductPrice;
                Product t = new Product(someProduct.ProductName, someProduct.ProductPrice);
                BugOfproducts.Add(t);

                Console.WriteLine($"{Name} купил {someProduct.ProductName}");
            }
            else { Console.WriteLine($"{Name} не может себе позволить купить {someProduct.ProductName}"); }
            
        }

        public void printInfo()
        {
            if (Name == null) { Console.WriteLine("Персона не могла ничего купить, так как у неё нет имени."); }
            else
            {
                Console.Write($"{Name} - ");
                if (BugOfproducts.Count == 0) { Console.Write("Ничего не купил(a)"); }
                else
                {
                    for (int i = 0; i < BugOfproducts.Count; i++)
                    {
                        if (i != BugOfproducts.Count - 1) { Console.Write($"{BugOfproducts[i].ProductName},"); }
                        else { Console.Write($"{BugOfproducts[i].ProductName}"); }
                    }
                }
            }
        }

    }
}
