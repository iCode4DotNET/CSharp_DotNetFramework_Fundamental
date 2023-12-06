using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ 1 ]
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = 0; //حتمن مقدار اولیه 0 میخواهد
            float average = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];// sum = sum + numbers[i];
            }

            // 5/2 = 2 !!!!!!!!!!!!!!!!!!!!!!!!
            //  average = sum / numbers.Length; //تقسیم بصورت عدد صحیح


            //5/2 = 2.5 :-)
            average = (float)sum / numbers.Length; // تقسیم بصورت عدد اعشاری

            //-------------اشتباه---------
            // average = (float)(sum / numbers.Length); // تقسیم بصورت عدد صحیح
            //----------------------

            // به صورت خیلی شفاف----------------------
            float myFloatVersionOfSum = (float)sum;
            average = myFloatVersionOfSum / numbers.Length;
            //------------------------------------------

            string myFormat = "The Sum of {0} Numbers = {1}\nThe Average of {0} Numbers = {2}";

            Console.WriteLine(myFormat, numbers.Length, sum, average);
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
            //const int N = 3;
            //int sum = 0;
            //float average = 0;

            //Console.WriteLine("You Should Enter {0} Numbers : ", N);

            //int[] numbers = new int[N];

            //for (int i = 0; i < N; i++)
            //{
            //    if (i == N - 1)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //    }
            //    Console.Write("Plz Enter Number {0} : ", i + 1);
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //Console.ForegroundColor = ConsoleColor.Green;

            //for (int i = 0; i < N; i++)
            //{
            //    sum += numbers[i];
            //}

            //average = (float)sum / N;

            //Console.WriteLine($"The Sum of {N} Numbers = {sum}\nThe Average of {N} Numbers = {average}"); 
            #endregion


            Console.ReadKey();
        }
    }
}
