using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02
{
    internal class Program
    {
        /// <summary>
        /// یک نوع داده ایی جدید برای روز های هفته
        /// </summary>
        public enum RoozHayeHafte
        {
            Shanbe, 
            YekShanbe,
            DoShanbe, 
            SeShanbe, 
            ChaharShanbe, 
            PanjShanbe, 
            Jome
        };


        public enum RoozHayeHafte2 : byte
        {
            شنبه,
            یکشنبه ,
            دوشنبه = 200,
            سه_شنبه,
            چهارشنبه,
            پنج_شنبه,
            جمعه
        };


        /// <summary>
        /// انواع مدارک تحصیلی
        /// </summary>
        public enum EducationType 
        {
            Diplom, 
            FogheDiplom, 
            Lisans = 1000, 
            FogheLisans, 
            PhD = 1003
        }



        static void Main(string[] args)
        {

            // Simple   : int , char , float , double , string , ....
            // Complex  : DateTime 

            // DataType varibleName = value ; 
            // DataType varibleName = new DataType() ;


            int age = 10;

            RoozHayeHafte emrooz = RoozHayeHafte.ChaharShanbe;

            EducationType madrak = EducationType.FogheLisans;

            int fogheLisansNumber = (int)EducationType.FogheLisans;


            RoozHayeHafte2 rooz = RoozHayeHafte2.پنج_شنبه;


            DateTime alan = new DateTime();

            Console.WriteLine(alan.ToLongDateString());

            alan = DateTime.Now;

            Console.WriteLine(alan.ToLongDateString());


            DateTime myBirthdate = new DateTime(1984, 01, 31); // 1362/11/11

            PersianCalendar pc = new PersianCalendar();

            int year = pc.GetYear(myBirthdate);
            int month = pc.GetMonth(myBirthdate);
            int day = pc.GetDayOfMonth(myBirthdate);

            Console.WriteLine("{0}/{1}/{2}", year, month, day);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"{year}/{month}/{day}");


            Console.ReadKey();

        }
    }
}
