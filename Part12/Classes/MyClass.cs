using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part12.Classes
{
   public class MyClass
    {
        /// <summary>
        /// Call by Value فراخوانی با مقدار
        /// </summary>
        public static void DoSomething(int input)
        {
            input += 1000;
            Console.WriteLine($"inside method value = {input}");
        }

        /// <summary>
        /// Call by Reference فراخوانی با آدرس - رفرنس
        /// </summary>
        public static void DoSomething(ref int input)
        {
            input += 2000;
            Console.WriteLine($"inside method value = {input}");
        }


        // مثال خود سی شارپ
        // TryParse

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


        // مثال خود سی شارپ params
        
         
        public static void ShowNumbers(params int[] input)
        {

            string[] parts = "".Split('-', '=', ',');

            foreach (var item in input)
            {
                Console.WriteLine($"the input values = {item}");
            }
        }


        //A params parameter must be the last parameter in a parameter list
        //public static void ShowNumbers2(params int[] input , int alaki) { }

        //public static void ShowNumbers2(params int[] input , string alaki) { }

        public static void ShowNumbers2(string alaki,params int[] input ) { }

    }
}
