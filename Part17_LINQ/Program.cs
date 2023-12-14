using SadrTools.Utility;
using SadrTools.Extension;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;

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
            Console.WriteLine(result.Substring(0, result.Length - 1));
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



            var birthdate = new DateTime(2000, 1, 1);

            Console.WriteLine(SadrTools.Utility.DateHelper.ToPersianDate(birthdate));
            Console.WriteLine(DateHelper.ToPersianDate(birthdate));
            Console.WriteLine(birthdate.ToPersianDate());
            Console.WriteLine(birthdate.ToPersianDate('*'));

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(linq08.Print());
            Console.WriteLine(linq09.Print());

            Console.Clear();


            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("F:\\IT\\Dotin\\BootCamp\\C#\\DotNewFramework\\CSharp_DotNetFramework_Fundamental");

            FileInfo[] files = di.GetFiles();


            var linq10 = (from f in files
                          select f);


            foreach (var item in linq10)
            {
                //Console.Write(item.FullName);
                Console.WriteLine(item.Name);
                Console.WriteLine(" : " + item.Extension);
            }

            Console.Clear();

            files = di.GetFiles("*.*", SearchOption.AllDirectories);

            var linq11 = (from f in files
                          orderby f.Length descending
                          select f
                          
                );


            foreach (var item in linq11)
            {
                Console.WriteLine($"{item.Name} : {item.Length}");          
            }

            //Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("JUST C# FILES !!");

            // png PNG JPG jpg
            var linq12 = (from f in files
                          where f.Extension.ToLower() == ".cs".ToLower()
                          orderby f.Length descending
                          select f);

            //foreach (var item in linq12)
            //{
            //    Console.WriteLine($"{item.Name} : {item.Length}");
            //}


            Console.WriteLine(linq12.Print());

            Console.WriteLine("-------------------Bitwise operation-------------------------");

            var linq13 = (from f in files
                          where (f.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
                          orderby f.Length descending
                          select f);

            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators

            // 0101 == 5
            // 1010 == 10
            // 0101 == 5


            Console.WriteLine(linq13.Print());


            var linq14 = (from f in files
                          where (f.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden &&
                                (f.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly
                          orderby f.Length descending
                          select f);

            Console.WriteLine(linq14.Print());


            Console.ReadKey();

        }
    }
}