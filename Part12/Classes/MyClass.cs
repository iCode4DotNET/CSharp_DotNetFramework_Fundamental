using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part12.Classes
{
   public class MyClass
    {
        public static void DoSomething(int input)
        {
            input += 1000;
            Console.WriteLine($"inside method value = {input}");
        }

        public static void DoSomething(ref int input)
        {
            input += 2000;
            Console.WriteLine($"inside method value = {input}");
        }

        public static void DoSomething2(out int input)
        {
            input = 0;
            input += 3000;
        }

        public static void DoSomething2(out int input1 , out int input2)
        {
            input1 = 0;
            input1 += 3000;
            input2 = 0;
            input2 += 4000;
        }


        public static void ShowArrayValues(int[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine($"the values in array = {item}");
            }
        }


        public static void ShowNumbers(params int[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine($"the input values = {item}");
            }
        }
    }
}
