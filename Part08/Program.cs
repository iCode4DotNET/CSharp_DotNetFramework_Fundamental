using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ 1 ]
            Random rand = new Random();
            int computerRandom = rand.Next(100);

            while (true)
            {
                Console.ResetColor();
                Console.Write("Plz Enter Your Guess !! : ");
                int userGuess = int.Parse(Console.ReadLine());

                if (userGuess == computerRandom)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("OK :-) You are Right !! ");
                    break;
                }

                else if (computerRandom < userGuess)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Your Number Should be lower ... !  ");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Your Number Should be greater ... !  ");
                }
            }

            Console.WriteLine("Good Job ! Bye Bye :-)");
            #endregion

            #region [ 2 ]
            //Random rand = new Random();
            //int computerRandom = rand.Next(100);

            //Boolean isContinue = true;

            //while (isContinue)
            //{
            //    Console.ResetColor();
            //    Console.Write("Plz Enter Your Guess !! : ");
            //    int userGuess = int.Parse(Console.ReadLine());

            //    if (userGuess == computerRandom)
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //        Console.WriteLine("OK :-) You are Right !! ");
            //        isContinue = false;
            //        continue;
            //    }

            //    else if (computerRandom < userGuess)
            //    {

            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine(" Your Number Should be lower ... !  ");

            //    }
            //    else
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //        Console.WriteLine(" Your Number Should be greater ... !  ");
            //    }
            //}

            //Console.WriteLine("Good Job ! Bye Bye :-) :-)"); 
            #endregion

            Console.ReadKey();
        }
    }
}
