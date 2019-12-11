using System;
using System.Collections.Generic;
using System.Text;

namespace задание_3_лаба_121
{
    class CalculationHandler
    {
        public CalculationHandler() { }

        public void Calculation(char @operator, int firstOperand, int secondOperand)
        {
            if (@operator == '+')
            { Console.WriteLine(firstOperand + secondOperand); }

            else if (@operator == '-')
            { Console.WriteLine(firstOperand - secondOperand); }

            else if (@operator == '/')
            {
                if(firstOperand == 0 || secondOperand == 0)
                { Console.WriteLine("Can`t devide on zero!"); }
                else
                { Console.WriteLine(firstOperand / secondOperand); }
            }

            else if(@operator == '*')
            { Console.WriteLine(firstOperand * secondOperand); }

            else { Console.WriteLine("Invalid Operator!"); }
        }
    }
}
