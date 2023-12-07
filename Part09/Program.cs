using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Part09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ 1 ]
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int sum = 0; //حتمن مقدار اولیه 0 میخواهد
            //float average = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];// sum = sum + numbers[i];
            //}

            //// 5/2 = 2 !!!!!!!!!!!!!!!!!!!!!!!!
            ////  average = sum / numbers.Length; //تقسیم بصورت عدد صحیح


            ////5/2 = 2.5 :-)
            //average = (float)sum / numbers.Length; // تقسیم بصورت عدد اعشاری

            ////-------------اشتباه---------
            //// average = (float)(sum / numbers.Length); // تقسیم بصورت عدد صحیح
            ////----------------------

            //// به صورت خیلی شفاف----------------------
            //float myFloatVersionOfSum = (float)sum;
            //average = myFloatVersionOfSum / numbers.Length;
            ////------------------------------------------

            //string myFormat = "The Sum of {0} Numbers = {1}\nThe Average of {0} Numbers = {2}";

            //Console.WriteLine(myFormat, numbers.Length, sum, average);
            #endregion

            #region [ 2 ]
            //int sum = 0;
            //float average = 0;
            //Console.WriteLine("You Should Enter 10 Numbers : ");

            //int[] numbers = new int[10];

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Plz Enter Number {0} : ", i + 1);
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //average = (float)sum / numbers.Length;

            //string myFormat = "The Sum of {0} Numbers = {1}\nThe Average of {0} Numbers = {2}";

            //Console.WriteLine(myFormat, numbers.Length, sum, average);
            #endregion

            #region [ 3 ]
            const int SIZE = 10;
            int sum = 0;
            float average = 0;

           // SIZE = 4; //The left-hand side of an assignment must be a variable, property or indexer 
           // SIZE++; //The operand of an increment or decrement operator must be a variable, property or indexer   



            Console.WriteLine("You Should Enter {0} Numbers : ", SIZE);

            int[] numbers = new int[SIZE];

            for (int i = 0; i < SIZE; i++)
            {
                if (i == SIZE - 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write("Plz Enter Number {0} : ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green;

            for (int i = 0; i < SIZE; i++)
            {
                sum += numbers[i];
            }

            average = (float)sum / SIZE;

            Console.WriteLine($"The Sum of {SIZE} Numbers = {sum}\nThe Average of {SIZE} Numbers = {average}");
            #endregion


            Console.ReadKey();
        }
    }
}
