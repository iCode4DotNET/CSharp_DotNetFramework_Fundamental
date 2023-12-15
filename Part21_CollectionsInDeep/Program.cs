using System.Linq;
using System;

namespace Part21_CollectionsInDeep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ 01 ]

            int[] squares = { 1, 4, 9, 16 };

            int[] copy = new int[squares.Length];

            squares.CopyTo(copy, 0);

            // alternative way to copy using LINQ
            int[] copy2 = squares.ToArray(); // یک آرایه جدید

            int[] copy3 = squares; // آدرس ها یکی میشود

            squares[0] = 1234;

            foreach (int value in copy)
            {
                Console.WriteLine(value);
            }

            foreach (int value in copy2)
            {
                Console.WriteLine(value);
            }

            foreach (int value in copy3)
            {
                Console.WriteLine(value);
            }


            // False
            // آدرس شروع آرایه 
            Console.WriteLine(string.Format($"squares == copy2? {squares == copy2}"));
            Console.WriteLine(string.Format($"squares == copy3? {squares == copy3}"));


            Console.ReadKey();


            #endregion

            #region [ 06 ]

            Console.Clear();

            string[] daysOfWeek = {
                                      "Monday",
                                      "Tuesday",
                                      "Wednesday",
                                      "Thursday",
                                      "Friday",
                                      "Saturday",
                                      "Sunday"
                                  };


            Array.Sort(daysOfWeek);

            foreach (string day in daysOfWeek)
                Console.WriteLine(day);



            Console.ReadKey();


            // will sort the array in increasing order of length of string

             //var comparer = new StringLengthComparer();

            Array.Sort(daysOfWeek, new StringLengthComparer());

            foreach (string day in daysOfWeek)
                Console.WriteLine(day);

            Console.ReadKey();

            // will sort the array alphabetically
            Array.Sort(daysOfWeek);


            foreach (string day in daysOfWeek)
                Console.WriteLine(day);
            Console.ReadKey();
            #endregion

            Console.ReadKey();
        }
    }
}
