using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ for - ASCII Code ]

            for (int i = 48; i <= 57; i++)
            {
                Console.WriteLine($"Code = {i}\tChar = {(char)i}");
            }

            for (int i = 65; i <= 122; i++)
            {
                Console.WriteLine($"Code = {i}\tChar = {(char)i}");
            }

            #endregion

            Console.Clear();

            #region [ While - DoWhile ]
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine($"J = {j}");
                // j++;
                j += 2;
            }


            //-----------------------

            int k = 20;
            do
            {
                Console.WriteLine($"K = {k}");

            } while (k <= 10);
            #endregion

            Console.Clear();

            #region [ Array ]
            // Array آرایه ها 

            int[] numbers = new int[3];

            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.ForegroundColor = ConsoleColor.Red;


            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.ReadKey();
        }
    }
}
