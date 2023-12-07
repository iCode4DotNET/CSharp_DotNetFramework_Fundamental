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


            // Parse is a Method
            // Convert is a Class

            // Parse ( string to .....)
            // Convert.Method (.... to .... )



            int age = int.Parse(Console.ReadLine());

            //int age2 = Convert.ToSingle()

            byte age3 = byte.Parse(Console.ReadLine());

            long mylong = 123456;

            string tmp = Console.ReadLine();
            int age4 = int.Parse(tmp);

            float ff = float.Parse(Console.ReadLine());

            double dd = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Your Name = {name}\nYour Family = {family}\nYour Age = {age}");

            Console.ReadKey();
        }
    }
}
