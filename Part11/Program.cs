using Part11.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Value Type : stack , struct , non nullable
            int a = 10;
            int b = a;

            a++;

            Console.WriteLine($"a = {a} b = {b}");

            // Reference Type : heap , class , nullable

            string s1 = "Soroush Sadr";
            string s2 = s1;

            s1 = "Session 11";

            // string immutable

            //StringBuilder sb = new StringBuilder();

            Console.WriteLine($"s1 = {s1} s2 = {s2}");


            Console.ReadKey();

            int[] numbers1 = new int[3];
            numbers1[0] = 10;
            numbers1[1] = 20;
            numbers1[2] = 30;

            // 
            int[] numbers2 = numbers1;

            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }

            numbers1[1] = 2000;
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var item in numbers2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            Console.Clear();

            int[] myArray = new int[3];
            myArray[0] = 10;
            myArray[1] = 20;
            myArray[2] = 30;




            // int[] result = MyClass.ChangeArray(myArray);

            MyClass.ChangeArray(myArray);

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}