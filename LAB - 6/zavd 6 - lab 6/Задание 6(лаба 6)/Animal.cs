using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_6_лаба_6_
{
    class Animal
    {
        private string name;
        private int age;
        private string gender;

        public string TypeOfAnimal { get; set; }
        public string Name 
        {
            get { return name; }
            set
            {
                if (value == "")
                { throw new EmptyFieldException("Name field can`t be empty"); }
                for (int i=0;i<value.Length;i++)
                {
                    bool checkIfnumber = int.TryParse(Convert.ToString(value[i]), out int result);
                     if (checkIfnumber)
                    { throw new InvalidInputException("Invalid input!1"); }
                    else { name = value; }
                }
            }
        }
        public int Age 
        {
            get { return age; }
            set
            {
                if (value < 0)
                { throw new InvalidInputException("Invalid input!2"); }
                else { age = value; }
            }
        }
        public string Gender
        {
            get { return gender; }
            set
            {
                if (value != "Male" && value != "Female" && value != "male" && value != "female" || (TypeOfAnimal == "FuturePet" && (value != "CatDog" && value != "DogCat")))
                {
                    if (value == "")
                    { throw new EmptyFieldException("Gender field can`t be empty"); }

                    if (TypeOfAnimal != "Kitten" && TypeOfAnimal != "Tomcat" && TypeOfAnimal != "FuturePet")
                    { throw new InvalidInputException("Invalid input!3"); }
                    else { gender = value; }
                }
                else { gender = value; }
            }
        }


        public Animal(string type, string name, int age, string gender)
        {
            TypeOfAnimal = type;
            Name = name;
            Age = age;
            Gender = gender;
        }

        public void CheckAndAddAnimal()
        {
            if(TypeOfAnimal == "Dog")
            { 
                Dog someDog = new Dog(TypeOfAnimal,Name,Age,Gender);
                someDog.Display();
                someDog.ProduceSound();
            }

            if(TypeOfAnimal == "Cat")
            { 
                Cat someCat = new Cat(TypeOfAnimal, Name, Age, Gender);
                someCat.Display();
                someCat.ProduceSound();
            }

            if (TypeOfAnimal == "Frog")
            { 
                Frog someFrog = new Frog(TypeOfAnimal, Name, Age, Gender);
                someFrog.Display();
                someFrog.ProduceSound();
            }

            if (TypeOfAnimal == "Kitten")
            { 
                Kitten someKitten = new Kitten(TypeOfAnimal, Name, Age, Gender);
                someKitten.Display();
                someKitten.ProduceSound();
            }

            if (TypeOfAnimal == "Tomcat")
            { 
                Tomcat someTomcat = new Tomcat(TypeOfAnimal, Name, Age, Gender);
                someTomcat.Display();
                someTomcat.ProduceSound();
            }

            if (TypeOfAnimal == "FuturePet")
            {
                FuturePet someFuturePet = new FuturePet(TypeOfAnimal, Name, Age, Gender);
                someFuturePet.Display();
                someFuturePet.ProduceSound();
            }
        }

        public virtual void ProduceSound()
        {
            if (Gender == "CatDog")
            { Console.WriteLine("MEOW WOOf"); }

            else if (Gender == "DogCat")
            { Console.WriteLine("WOOf MEOW"); }

            else { Console.WriteLine("BOOM"); Console.WriteLine(Gender); }
        }

        public virtual void Display()
        { Console.WriteLine($"{TypeOfAnimal}\n{Name} {Age} {Gender}");  }

        class Dog : Animal
        {
            public Dog(string type, string name, int age, string gender)
                :base(type,name,age,gender)
            {  
            }

            public override void ProduceSound()
            { Console.WriteLine("Woof!"); }

            public override void Display()
            { base.Display(); }
        }

        class Cat : Animal
        {
            public Cat(string type, string name, int age, string gender)
                 : base(type, name, age, gender)
            {
            }

            public override void ProduceSound()
            { Console.WriteLine("Meow meow"); }

            public override void Display()
            { base.Display(); }
        }

        class Frog : Animal
        {
            public Frog(string type, string name, int age, string gender)
               : base(type, name, age, gender)
            {
            }

            public override void ProduceSound()
            { Console.WriteLine("Ribbit"); }

            public override void Display()
            { base.Display(); }
        }

        class Kitten : Animal
        {
            public Kitten(string type,string name,int age,string gender)
                :base(type,name,age,gender)
            {
                Gender = "Female";
            }

            public override void ProduceSound()
            { Console.WriteLine("Meow"); }

            public override void Display()
            { base.Display(); }
        }

        class Tomcat : Animal
        {
            public Tomcat(string type, string name, int age, string gender)
                : base(type, name, age, gender)
            {
                Gender = "Male";
            }

            public override void ProduceSound()
            { Console.WriteLine("MEOW"); }

            public override void Display()
            { base.Display(); }
        }

        class FuturePet : Animal
        {
            public FuturePet(string type, string name, int age, string gender)
                : base(type, name, age, gender)
            { }

            public override void ProduceSound()
            {
                base.ProduceSound();
            }
        }
    }
}
