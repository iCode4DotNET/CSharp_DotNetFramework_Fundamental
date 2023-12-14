using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using SadrTools.Extension;

namespace Part18_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 32432, 99, 43, 4, 999998, 32, 999999, 432, 4, 32, 43, 24, 32, 4265, 765, 765, 7, 657, 65, 756 };

            var linq01 = from n in numbers
                         where n > 99 && n < 1000
                         select n;

            var linq02 = from n in numbers
                         where n.ToString().Length == 3
                         select n;

            var linq03 = from n in numbers
                         where n.ToString().StartsWith("4")
                         select n;

            var linq04 = from n in numbers
                         where n.ToString().EndsWith("4")
                         select n;

            var linq05 = from n in numbers
                         where n.ToString().Contains("4")
                         select n;

            // DOES NOT START WITH 4 ,
            // DOES NOT END WITH 4 ,
            // BUT CONTAINS 4


            int linq06 = (from n in numbers
                          where n.ToString().Contains("4")
                          select n).Sum();

            int linq07 = (from n in numbers
                          where n.ToString().Contains("4")
                          select n).Min();

            int linq08 = (from n in numbers
                          where n.ToString().Contains("4")
                          select n).Max();


            double linq09 = (from n in numbers
                             where n.ToString().Contains("4")
                             select n).Average();

            int linq10 = (from n in numbers
                          where n.ToString().Contains("4")
                          select n).Count();


            int[] linq11 = (from n in numbers
                            where n.ToString().Contains("4")
                            select n).ToArray();

            List<int> linq12 = (from n in numbers
                                where n.ToString().Contains("4")
                                select n).ToList();

            List<int> linq13 = (from n in numbers
                                where n.ToString().Contains("4")
                                select n).Distinct().ToList();

            // CHEAT SHEET LINQ

            int linq14 = (from n in numbers
                          where n.ToString().Length == 2
                          select n).First();

            int linq15 = (from n in numbers
                          where n.ToString().Length == 2
                          select n).Last();


            //Sequence contains no elements

            //int linq16 = (from n in numbers
            //              where n.ToString().Length == 20
            //              select n).First();

            int linq17 = (from n in numbers
                          where n.ToString().Length == 20
                          select n).FirstOrDefault();

            // Sequence contains more than one element

            //int linq18 = (from n in numbers
            //              where n.ToString().Length == 6
            //              select n).Single();

            //int linq19 = (from n in numbers
            //              where n.ToString().Length == 6
            //              select n).SingleOrDefault();


            //int linq20 = (from n in numbers
            //              where n.ToString().Length == 20
            //              select n).Single();

            int linq21 = (from n in numbers
                          where n.ToString().Length == 20
                          select n).SingleOrDefault();



            //var linq22 = (from n in numbers
            //              group n by n % 3 into grp
            //              select n);


            //IEnumerable<IGrouping<int, int>> linq22 = (from n in numbers
            //                                           group n by n % 3 into grp
            //                                           select grp);



            var linq22 = (from n in numbers
                          group n by n % 5 into grp
                          select new
                          {
                              Remainder = grp.Key,
                              NumbersInGroup = grp
                          });

            foreach (var item in linq22)
            {
                Console.WriteLine($"The Remainder : {item.Remainder}");

                var str = "";
                foreach (var number in item.NumbersInGroup)
                {
                    str += number + ",";
                }

                Console.WriteLine(str.RemoveLastCharacter());

            }

            Console.WriteLine("-------------------------");

            var linq23 = from n in linq22
                         orderby n.Remainder 
                         select n;


            foreach (var item in linq23)
            {
                Console.WriteLine($"The Remainder : {item.Remainder}");

                var str = "";
                foreach (var number in item.NumbersInGroup)
                {
                    str += number + ",";
                }

                Console.WriteLine(str.RemoveLastCharacter());

            }

            //task 1
            //  ali, reza, Amir , Anahita , Ramin , ......
            // تعداد اعضای هر گروه هم نمایش داده شود


            // task 2
            // نمایش اعداد / اسامی تکراری در یک مجموعه
            // با استفاده از گروپ بای

        }
    }
}
