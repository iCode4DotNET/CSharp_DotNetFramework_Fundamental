using SadrTools.Utility;
using SadrTools.Extension;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Part17_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region [ توضیحات var ]
          
            var x1 = 1234;

            //x1 = "salam";

            var x2 = DateTime.Now;

            var pc = new PersianCalendar();

            PersianCalendar pc2 = new PersianCalendar();

            //Feature 'target-typed object creation' is not available in C# 7.3.
            //Please use language version 9.0 or greater.	

            //PersianCalendar pc3 = new (); 
            #endregion


            // Linq : Language Integrated Query

            // با استفاده از لینک ، میتوان از هر مجموعه ای ، کوئری گرفت

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 54, 5435, 4, 5, 435, 435, 3, 5, 34, 67, 657, 67, 65, 7, 567, 567, 999 };

            var linq01 = from n in numbers
                         select n;

            IEnumerable<int> linq02 = from n in numbers
                                      select n;

            var linq03 = from n in numbers
                         orderby n
                         select n;

            IOrderedEnumerable<int> linq04 = from n in numbers
                                             orderby n
                                             select n;

           
            var linq05 = from n in numbers
                         where n > 500
                         select n;


            foreach (var item in linq05)
            {
                Console.WriteLine(item);
            }

            var linq06 = (from n in numbers
                         select n).Count();

            Console.WriteLine(linq06);

            var linq07 = (from n in numbers
                          select n).Distinct().Count();

            Console.WriteLine(linq07);



            // 324,432,423,423,4,32,4,324,4,32,32
            var linq08 = (from n in numbers
                          orderby n ascending
                          select n);

            var result = "";

            foreach (var item in linq08)
            {
                result += item + ",";
            }

            Console.WriteLine(result);
            Console.WriteLine(result.Substring(0,result.Length-1));
            Console.WriteLine(SadrTools.Utility.StringHelper.RemoveLastCharacter(result));
            Console.WriteLine(StringHelper.RemoveLastCharacter(result));


            var linq09 = (from n in numbers
                          orderby n ascending
                          select n).Distinct();

            result = "";

            foreach (var item in linq09)
            {
                result += item + ",";
            }

            Console.WriteLine(StringHelper.RemoveLastCharacter(result));



            var birthdate = new DateTime(2000,1,1);

            Console.WriteLine(SadrTools.Utility.DateHelper.ToPersianDate(birthdate));
            Console.WriteLine(DateHelper.ToPersianDate(birthdate));
            Console.WriteLine(birthdate.ToPersianDate());
            Console.WriteLine(birthdate.ToPersianDate('*'));

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(linq08.Print());
            Console.WriteLine(linq09.Print());


            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("C:\\");

            // var files =  di.ABC ();

            // linq on files

            // list all 
            // order by size , extension , ....
            // where size , extension , name , ..........
            
            // hidden , archive , ( ********* )


            // size byte :  KB , MB , GB 

            Console.ReadKey();

        }
    }
}