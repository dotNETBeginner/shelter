using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace _1_задание_11_лаба
{
    class RichSoilLand
    {
        private Int32 testInt;
        public Double testDouble;
        protected String testString;
        private Int64 testLong;
        protected Double aDouble;
        public String aString;
        public StringBuilder aBuilder;
        private Char testChar;
        public Int16 testShort;
        protected Byte testByte;
        public Byte aByte;
        protected StringBuilder aBuffer;
        protected Single aFloat;
        private Object aPredicate;
        protected Object testPredicate;
        public Object anObject;
        private Object hiddenObject;
        protected Object fatherMotherObject;
        private String anotherString;
        protected String moarString;
        public Int32 anotherIntBitesTheDust;
        private Exception internalException;
        protected Exception inheritableException;
        public Exception justException;

        public RichSoilLand() { }

        public void DisplayInfo(string args)
        {
            Type someType = this.GetType(); ;
            FieldInfo[] someInfo = someType.GetFields();

            if (args == "private" || args == "protected")
            { someInfo = someType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance); }
            
            else if(args == "ALL")
            { someInfo = someType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public); }

            foreach(FieldInfo i in someInfo)
            {
                if (args != "public" && args != "ALL")
                {
                    if (args == "private")
                    {
                        if (i.IsPrivate)
                        { Console.WriteLine($"Private {i.FieldType} {i.Name}"); }
                    }
                    else if(args == "protected")
                    {
                        if (!i.IsPrivate)
                        { Console.WriteLine($"Protected {i.FieldType} {i.Name}"); }
                    }
                }
                
                else if(args == "public")
                { Console.WriteLine($"public {i.FieldType} {i.Name}"); }

                else if (args == "ALL")
                { Console.WriteLine($" {i.FieldType} {i.Name}"); Console.WriteLine("Pizda"); }
            }

        }


    }
}
