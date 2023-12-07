using System;
using System.Collections;
using System.Collections.Generic;

namespace Part14_Array_ArrayList_GenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array arr = new Array(); // Dont Try !

            //int[] numbers = new int[] { 1, 2, 30, 4, 50, 6, 7, 8, 9, 10, 0, -1, -2, -3, -4, 20 };

            //// best practice 
            //Array.Sort(numbers);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ForegroundColor = ConsoleColor.Green;

            //Array.Reverse(numbers);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] result = Array.FindAll(numbers, n => n.CompareTo(20) > 0);

            //int[] result2 = Array.FindAll(numbers, x => x > 5);

            //int result3 = Array.Find(numbers, x => x > 5);


            //Console.ResetColor();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList al = new ArrayList();
            //al.Add(123);
            //al.Add("123");
            //al.Add("123ABC");
            //al.Add("ABC123");
            //al.Add(12.3);
            //al.Add(12.3F);
            //al.Add(true);
            //al.Add('X');

            System.Collections.ArrayList al = new ArrayList
            {
                123,
                "123",
                "123ABC",
                "ABC123",
                12.3,
                12.3F,
                true,
                'X'
            };

            foreach (object item in al)
            {
                Console.WriteLine(item);
            }


            foreach (var item in al)
            {
                if (item.GetType() == typeof(string))
                {
                    Console.WriteLine(item);
                }

                if (item.GetType() == typeof(int))
                {
                    Console.WriteLine(item);
                }

                if (item.GetType() == typeof(bool))
                {
                    Console.WriteLine(item);
                }
            }


            int[] myArray = new int[] { 200, 201, 202, 203, 204, 205 };

            System.Collections.Generic.List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(12);
            numbers.Add(123);
            numbers.Add(1234);
            numbers.Add(12345);

            numbers.AddRange(myArray);

            numbers.Add(1000);

            numbers.Insert(index: 0, item: 0);

            numbers.RemoveAll(match: x => x > 0);

            numbers.RemoveAt(index: 0);

            numbers.Remove(item: 123);

            numbers[6] = 666;

            foreach (var item in numbers)
            {
                Console.WriteLine(value: item);
            }


            Console.ReadKey();
        }
    }
}