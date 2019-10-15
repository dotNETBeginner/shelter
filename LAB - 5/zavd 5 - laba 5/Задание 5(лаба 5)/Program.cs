using System;

namespace Задание_5_лаба_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Pizza and then name of pizza.\n");

            Pizza somePizza = new Pizza();

            string[] s = Console.ReadLine().Split(" ");

            if (checkIfCorrect(s, "Pizza")) {somePizza=new Pizza(s); }

            Console.WriteLine("Now, input Dought and properties - Dough *Type of Dough* *Bake technique* *Dough weight*");
            s = Console.ReadLine().Split(" ");

            if (checkIfCorrect(s, "Dough")) {somePizza.addDoughInPizza(s); }

            Console.WriteLine("Now, input Topping and properties - Topping *Type of Topping* *Weight of topping* ");

            s = Console.ReadLine().Split(" ");

            while(s[0] != "End")
            {
                if (checkIfCorrect(s, "Topping")) { somePizza.addToppingInPizza(s); }
                s = Console.ReadLine().Split(" ");
            }

            somePizza.displayCaloryOfPizza();
        }
         static bool checkIfCorrect(string[] s,string name)
        {
            bool checkCorrectness = false;
            if (s[0] != name)
            {
                while (s[0] != name)
                {
                    Console.WriteLine($"The command you specified is not a  {name}, command, rewrite the command again!\n");
                    s = Console.ReadLine().Split(" ");
                }
            }
            else { checkCorrectness = true; }
            return checkCorrectness;
        }
    }
}
