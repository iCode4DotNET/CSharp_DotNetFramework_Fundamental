using Part10.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Console.Write("Plz Enter Your Message : ");
           string input = Console.ReadLine();
           ShowMessage(input);
           */


            int javab = MySimpleMathClass.DoSum(12, 20);

            Console.WriteLine($"Javab = {javab}");


            float sum = MySimpleMathClass.DoSum(12.3F, 12);

            Console.ReadKey();
        }


        static void ShowMessage(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your Message  = {msg}");
        }
    }
}