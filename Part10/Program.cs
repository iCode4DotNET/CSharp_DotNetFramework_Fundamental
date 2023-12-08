using Part10.Classes;
using System;

namespace Part10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METHOD 

            // BLACK BOX
            // DRY
            // RE USABILITY
            // TEAM WORK 
            // TEST 

            // یک کار انجام دهد درست انجام دهد و از اسم متد مشخص شود
            // ACTION ==> NAMING CONVENTION 
            // SINGLE RESPONSIBILITY 


            // IN , OUT (توصیه میکنم)
            // -  , OUT
            // IN , -
            // -  , - ==> به احتمال زیاد متغیر سراسری دارد


            // NAMING CONVENTION : PASCAL CASE 


            // تا اطلاع ثانوی
            // همه متد های ما در کلاس هایی از نوع استاتیک قرار میگیرند


            // کلاس استاتیک
            // محلی برای نگه داری متد های استاتیک و از یک خانواده


            // آیا یک متد میتواند بیشتر از یک مقدار خروجی داشته باشد؟


            Console.Write("Plz Enter Your Message : ");
            string input = Console.ReadLine();
            ShowMessage(input);

            // فراخوانی متد
            // صدا کردن متد
            // Call / Invoke
            Part10.Classes.Test.ShowGreeting();


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