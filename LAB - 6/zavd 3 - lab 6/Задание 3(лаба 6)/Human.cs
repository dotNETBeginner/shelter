using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_3_лаба_6_
{
    abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                bool firstLetterIsUpper;
                firstLetterIsUpper = Char.IsUpper(value[0]);
                
                if(!firstLetterIsUpper)
                { throw new ArgumentException("Expected upper case letter! Argument: firstName"); }
                else if(value.Length <= 3)
                { throw new ArgumentException("Expected lenght at least 4 symbols! Argument: firstName"); }
                else { firstName = value; }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                bool firstLetterIsUpper;
                firstLetterIsUpper = Char.IsUpper(value[0]);

                if (!firstLetterIsUpper)
                { throw new ArgumentException("Expected upper case letter! Argument: lastName"); }
                else if (value.Length <= 2)
                { throw new ArgumentException("Expected lenght at least 3 symbols! Argument: lastName"); }
                else { lastName = value; }
            }
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void Display()
        {
            Console.WriteLine($"First Name: {FirstName}\n\nLast Name: {LastName}\n");
        }
    }
}
