using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_console_Application
{
    class primative_datatypes
    {
        public static void dataTypes()
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Usman";
            bool isCoding= true;
            var name = "Usman";

            Console.WriteLine("\n\nPrimitive DataTypes:");
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(number);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isCoding);
            Console.WriteLine(name);
        }

        public static void limits() {
            Console.WriteLine("\n\nDataTypes Limits:");
            Console.WriteLine("Byte: {0} {1}",byte.MinValue,byte.MaxValue);
            Console.WriteLine("Float: {0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("Decimal: {0} {1}", decimal.MinValue, decimal.MaxValue);
        }
        public static void typeConversion()
        {
            Console.WriteLine("\n\nType Conversion:");
            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);

            try
            {
                string number = "1234";
                int num = Convert.ToInt32(number);
                byte numByte = Convert.ToByte(number);
                Console.WriteLine(number);
            }
            catch (Exception ex)
            {
               Console.WriteLine("The number cannot be converted to byte");
            } 
            


        }
        public static void operators()
        {
            Console.WriteLine("\n\nOperators:");
            var a = 1;
            var b = 5;
            var c = 37;

            try
            {
                Console.WriteLine(a+b*c);
                Console.WriteLine(c/b+a);
                Console.WriteLine(c / (float)b + a);
                Console.WriteLine(c>b || c==a);

            }
            catch (Exception ex)
            {
                Console.WriteLine("The number cannot be converted to byte");
            }



        }
    }
}
