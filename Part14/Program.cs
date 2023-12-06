using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array arr = new Array(); // Dont Try !

            int[] numbers = new int[] { 1, 2, 30, 4, 50, 6, 7, 8, 9, 10, 0, -1, -2, -3, -4, 20 };

            Array.Sort(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Array.Reverse(numbers);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            int[] result = Array.FindAll(numbers, n => n.CompareTo(20) > 0);

            Console.ResetColor();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }



            ArrayList al = new ArrayList();
            al.Add(123);
            al.Add("123");
            al.Add("123ABC");
            al.Add("ABC123");
            al.Add(12.3);
            al.Add(12.3F);
            al.Add(true);
            al.Add('X');

            foreach (var item in al)
            {
                //  Console.WriteLine(item);
            }


            foreach (var item in al)
            {
                if (item.GetType() == typeof(String))
                {
                    Console.WriteLine(item);
                }

                if (item.GetType() == typeof(Int32))
                {
                    Console.WriteLine(item);
                }

                if (item.GetType() == typeof(Boolean))
                {
                    Console.WriteLine(item);
                }
            }


            //int[] myArray = new int[] { 200, 201, 202, 203, 204, 205 };

            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(12);
            //numbers.Add(123);
            //numbers.Add(1234);
            //numbers.Add(12345);

            //numbers.AddRange(myArray);

            //numbers.Add(1000);

            //numbers.Insert(0, 0);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            Console.ReadKey();
        }
    }
}
