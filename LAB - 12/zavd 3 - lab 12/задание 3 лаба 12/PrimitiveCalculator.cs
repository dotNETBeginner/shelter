using System;
using System.Collections.Generic;
using System.Text;

namespace задание_3_лаба_121
{
    public delegate void CaclHandler(char @operator, int firstOperand, int secondOperand);

    class PrimitiveCalculator
    {
        private char _operator;

        public event CaclHandler CalcEvent;

        public CalculationHandler SomeHandler;

        public PrimitiveCalculator()
        {
             _operator = '+';

            SomeHandler = new CalculationHandler();
            CalcEvent = SomeHandler.Calculation;
        }

        public void ChangeStrategy(char @operator) => _operator = @operator; 

        public void PerformCalculation(int firstOperand, int secondOperand)
        { CalcEvent.Invoke(_operator, firstOperand, secondOperand); }
    }
}
