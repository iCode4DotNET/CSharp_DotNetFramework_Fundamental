using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Plz Enter Your Name : ");
            string name = Console.ReadLine();

            Console.Write("Plz Enter Your Family : ");
            string family = Console.ReadLine();

            Console.Write("Plz Enter Your Age : ");

            //  int age = int.Parse(Console.ReadLine());

            //  int age2 = Convert.ToInt32(Console.ReadLine());

            byte age = byte.Parse(Console.ReadLine());

            float ff = float.Parse(Console.ReadLine());

            double dd = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Your Name = {name}\nYour Family = {family}\nYour Age = {age}");

            Console.ReadKey();
        }
    }
}
