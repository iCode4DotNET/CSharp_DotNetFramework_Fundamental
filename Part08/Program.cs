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


//  MODE GAME  : 1 SIMPLE 2 NORMAL 3 HARD

// SIMPLE : (0-100) بدون محدودیت در تعداد بتونه حدس بزنه
// NORMAL : MAX 20 ( RANGE : 0- 200 )
// HARD   : MAX 10  ( NO RANGE )


// IF MAX/2 PASSED => HELP ? YES :
// ( تعداد رقم - زوج فرد - نصف ارقام نمایش داده شود - کل ارقام به شکل بهم ریخته نمایش داده شود )
// CHANCES - 2  


// IF JUST ONE CHANCE LEFT : SEE ADS ? YES  :  1MIN ADS 

// CHANCES + 2


// END ==> RE PLAY ?  RESET , ...... 

// SHOW STATISTICS

// PLAY MUSIC ( OPTIONAL ) 