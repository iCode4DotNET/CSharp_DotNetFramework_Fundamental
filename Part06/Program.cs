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

            for (int i = 1; i <= 57; i++)
            {
                Console.WriteLine($"Code = {i}\tChar = {(char)i}");
            }

            for (int i = 65; i <= 122; i++)
            {
                Console.WriteLine($"Code = {i}\tChar = {(char)i}");
            }

            #endregion

            //Console.Clear();

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

            //Console.Clear();

            #region [ Classic Array ]
            // Array آرایه ها 

            // Fixed Size
            // Reference Type
            // 0 based index
            


            int[] numbers = new int[3];

            numbers[0] = 100;
            numbers[1] = 200;
            numbers[2] = 300;


            Console.WriteLine(numbers);


            for (int i = 0; i < numbers.Length; i++)
            {
                // محتوای خونه آی ام 
                //Console.WriteLine(numbers[i]);

                Console.WriteLine($"{i+1} : {numbers[i]}"); // OK

                //Console.WriteLine($"{i++} : {numbers[i]}"); // ERROR

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
