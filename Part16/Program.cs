
using SadrTools.Utility;
using System;

namespace Part16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result1 =  SadrTools.Utility.StringHelper.ToPascalCase("aaaaZZZZZbbbbbAAAAA");

            string date1 = SadrTools.Utility.DateHelper.ToPersianDate4(DateTime.Now);
            string date2 = SadrTools.Utility.DateHelper.ToPersianDate(DateTime.Now);

            string date4 = SadrTools.Utility.DateHelper.ToPersianDate4(DateTime.Now,'*');

            Console.WriteLine(result1);
            Console.WriteLine(date1);
            Console.WriteLine(date2);

            Console.WriteLine(date4);


            Console.Clear();

            for (byte i = 0; i < 40; i++) 
            {
                Console.Write($"{i}! = {NumericHelper.CalculateFactorial(i)}\t\t");
                Console.WriteLine($"{i}!!! = {NumericHelper.CalculateFactorial_Recursive(i)}");

            }



            Console.ReadKey();

        }
    }
}
