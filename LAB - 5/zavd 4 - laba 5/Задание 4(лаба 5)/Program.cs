using System;
using System.Collections.Generic;
namespace Задание_4_лаба_5_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите людей и их количество денег, по данному принципу - *Персона Деньги Персона Деньги и т.д*");
            string[] persons = Console.ReadLine().Split(" ");

            Console.WriteLine("Введите товары и их цену, по данному принципу - *Товар Цена Това Цена и т.д*");
            string[] products = Console.ReadLine().Split(" ");

            List<Person> groupOfPersons = new List<Person>();

            for(int i=0;i<persons.Length;i+=2)
            {
                Person t = new Person(i,persons);
                groupOfPersons.Add(t);
            }

            List<Product> groupOfProducts = new List<Product>();

            for (int i = 0; i < products.Length; i += 2)
            {
                Product t = new Product(i, products);
                groupOfProducts.Add(t);
            }

            Console.WriteLine("Персона может приобрести товар с помощью команды {Имя персоны} {Имя продукта}, или же, вы можете закончить этот процесс командой *End*");

            bool ifPersonExist = false;
            bool ifProductExist = false;

            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] commandS = command.Split(" ");

                int personMoney=0;
                int productPrice = 0;

                Product someProduct = new Product();

                for(int i=0;i<groupOfPersons.Count;i++)
                {
                    if (commandS[0] == groupOfPersons[i].Name) {ifPersonExist=true; personMoney = groupOfPersons[i].Money; }  //проверка сущевствует ли данная персона
                }

                for (int i = 0; i < groupOfProducts.Count; i++)
                {
                    if (commandS[1] == groupOfProducts[i].ProductName) 
                    { 
                        ifProductExist = true;
                        productPrice = groupOfProducts[i].ProductPrice;                                            //Проверка сущевствует ли товар
                        someProduct = new Product(groupOfProducts[i].ProductName,groupOfProducts[i].ProductPrice);
                    }  
                }

                if (ifPersonExist && ifProductExist)  //проверка сущевствуют ли введенные пользователем данные
                {
                    bool checkFirstException = false;
                    bool checkSecondException = false;
                    if (personMoney < 0) { checkFirstException = true; } //Проверка, если значение денег меньше 0

                    if(productPrice < 0) {checkSecondException = true; } //Проверка, если значение цены товара меньше 0

                    if (checkFirstException && !checkSecondException) {Console.WriteLine("Деньги не могут иметь отрицательное значение!"); }
                    else if (checkSecondException && !checkFirstException) { Console.WriteLine("Товар не может иметь отрицательное значение!"); }
                    else if(checkFirstException && checkSecondException) { Console.WriteLine("Цена товара и деньги не могут иметь отриацательное значение!"); }
                    else  //Если значение денег и цены товара корректные то выполнить следующий код
                    {
                        for(int i=0;i<groupOfPersons.Count;i++)
                        {
                            if (commandS[0] == groupOfPersons[i].Name) { groupOfPersons[i].addProductAtBug(someProduct);Console.WriteLine(); }  //использовать ф-цию добавления товара в багаж товаров
                        }
                    }
                }
                else {Console.WriteLine("Такой персоны или товара не сущевствует, или имя персоны, товара пустое!"); }

                command = Console.ReadLine();
            }

            for(int i = 0; i < groupOfPersons.Count; i++) { groupOfPersons[i].printInfo(); Console.WriteLine(); }  //Вывести состояние имени персоны и его багажа с товарами
        }

    }
}
