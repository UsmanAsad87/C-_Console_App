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
        }
    }
}
