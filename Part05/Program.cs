using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for 

            //  int i = 100;

            for (int i = 0; i <= 10; i++)
                Console.WriteLine(i);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("----");
            }


            Console.Clear();

            //  Console.ResetColor();


            int j = 0;

            for (j = 0; j < 10; j++)
            {
                // Do Something.....
            }
            Console.WriteLine("j = " + j);


            for (int i = 0; i <= 10; i++) ;
            //Console.WriteLine(i);


            int k = 0;
            for (k = 0; k <= 10; k++) ;
            Console.WriteLine("k = " + k);
            Console.WriteLine(DateTime.Now.ToLongDateString());

            Console.Clear();


            //for (int i = 0; i < 10; i--)
            //{
            //    System.Threading.Thread.Sleep(100);
            //    Console.WriteLine(DateTime.Now.ToLongTimeString());
            //}


            //  for (;;){}

            //  for (int i = 0; ; i++) { Console.WriteLine(i); }

            // for (int i = 0; ;) { Console.WriteLine(i); }


            Console.ReadKey();
        }
    }
}
