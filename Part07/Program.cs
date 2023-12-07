using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand1 = new Random();
            int random = rand1.Next();
            Console.WriteLine(random);

            random = rand1.Next(100);
            Console.WriteLine(random);


            random = rand1.Next(200, 300);
            Console.WriteLine(random);

            Console.ForegroundColor = ConsoleColor.Green;

            var rand2 = new Random();
            Console.WriteLine(rand2.Next());
            Console.WriteLine(rand2.Next());
            Console.WriteLine(rand2.Next());
            Console.WriteLine(rand2.Next());

            //System.Threading.Thread.Sleep(100);

            Console.WriteLine(rand2.Next());
            Console.WriteLine(rand2.Next());
            Console.WriteLine(rand2.Next());
            Console.WriteLine(rand2.Next());

            Console.ForegroundColor = ConsoleColor.Red;



            Console.WriteLine(new Random(1234).Next());



            //--------------------------------------

            Console.ForegroundColor = ConsoleColor.Green;

            Guid myRandom = new Guid();
            myRandom = Guid.NewGuid();

            Console.WriteLine(myRandom);

            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());
            Console.WriteLine(Guid.NewGuid());


            Console.WriteLine(myRandom.ToString().Replace("-", ""));
            Console.WriteLine(myRandom.ToString().Replace("-", "").Substring(10, 10));


            if (myRandom == Guid.Empty)
            {

            }


            Console.WriteLine(Guid.Empty);


            Console.ReadKey();
        }
    }
}
