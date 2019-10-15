using System;
using System.Collections.Generic;
using System.Text;

namespace Задание_5_лаба_5_
{
    class Dough
    {
        private string bakingTechnique;
        private string typeOfDough;
        private int doughWeight;
        private bool bakingTechniqueCheckForExceptions = false;
        public string BakingTechnique 
        {
            get { return bakingTechnique; }
            set
            {
                if(value != "Crispy" && value != "Chewy" && value != "Homemade")
                { bakingTechniqueCheckForExceptions = true; }

                if (value == "Crispy") { BakingTechniqueModifier = 0.9f; }
                if (value == "Chewy") { BakingTechniqueModifier = 1.1f; }
                if (value == "Homemade") { BakingTechniqueModifier = 1.0f; }
            }
        }
        public string TypeOfDough 
        {
            get { return typeOfDough; }
            set
            {
                if(value != "White" && value != "Wholegrain" || bakingTechniqueCheckForExceptions == true)
                { Console.WriteLine("Invalid type of dough.\n"); }
                else { typeOfDough = value; }

                if (value == "White") { DoughModifier = 1.5f; }
                if (value == "Wholegrain") { DoughModifier = 1.0f; }
            }
        }
        public float DoughModifier { get; set; }
        public float BakingTechniqueModifier { get; set; }
        public int DoughWeight
        {
            get { return doughWeight; }
            set
            {
                if (value <= 0 || value > 200)
                { if (typeOfDough != null) { Console.WriteLine("Dough weight should be in the range [1..200]\n"); } }
                else { doughWeight = value; }
            }
        }

        public Dough(string[] s)
        {
            TypeOfDough = s[1];
            BakingTechnique = s[2];
            DoughWeight = int.Parse(s[3]);
        }
    }
}
