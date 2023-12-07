using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part04
{
    internal class Program
    {
        public enum EducationType
        {
            Diplom, FogheDiplom, Lisans, FogheLisans, PhD
        }

        static void Main(string[] args)
        {
            #region [ Part 01 ]

            Console.Write("Plz Enter Your Age : ");
            //int.TryParse(Console.ReadLine(), out age);
            //Console.WriteLine($"Age = {age}");

            int age = 1234;
            bool isConvertedCorrectly = int.TryParse(Console.ReadLine(), out age);

            bool isConvertedCorrectly2 = int.TryParse(Console.ReadLine(), out int age2);


            if (isConvertedCorrectly == true)
            {

            }

            if (isConvertedCorrectly)
            {

            }

            if (isConvertedCorrectly2 == false)
            {

            }

            if (!isConvertedCorrectly)
            {

            }



            if (isConvertedCorrectly)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Age = {age}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Age = {age}");
            }


            if (isConvertedCorrectly)
                Console.ForegroundColor = ConsoleColor.Green;
            else
                Console.ForegroundColor = ConsoleColor.Red;


            int alaki = 123;


            Console.ForegroundColor = isConvertedCorrectly ? ConsoleColor.Green : ConsoleColor.Red;

            Console.ForegroundColor = !isConvertedCorrectly ? ConsoleColor.Red : ConsoleColor.Green;


            int c = isConvertedCorrectly ? 100 : alaki > 100 ? 1000 : 2000;


            Console.WriteLine($"Age = {age}");

            Console.ResetColor();

            Console.WriteLine("..... Continue ...........");



            #endregion


            switch (age)
            {
                case 10:
                    Console.WriteLine("your age is 10 ");
                    break;

                case 20:
                    Console.WriteLine("your age is 20 ");
                    break;

                case 30:
                    Console.WriteLine("your age is 30 ");
                    break;

                case 40:
                case 50:
                case 60:
                    Console.WriteLine("your age is 40-60 ");
                    break;

                default:
                    Console.WriteLine("....");
                    break;
            }


            EducationType madrak = EducationType.FogheLisans;

            switch (madrak)
            {
                case EducationType.Diplom:
                    break;

                case EducationType.FogheDiplom:
                    break;
            }


            switch (madrak)
            {
                case EducationType.Diplom:
                    break;
                case EducationType.FogheDiplom:
                    break;
                case EducationType.Lisans:
                    break;
                case EducationType.FogheLisans:
                    break;
                case EducationType.PhD:
                    break;
                default:
                    break;
            }


            double myGrade = 18.54;

            switch (myGrade)
            {

                default:
                    break;
            }

            bool? isSingle = null;

            int? myAge = null;

            Console.ReadKey();

        }
    }
}
