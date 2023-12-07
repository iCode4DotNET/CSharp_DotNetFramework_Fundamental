using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime alan = DateTime.Now;

            Console.WriteLine(alan.ToString("yyyy-MM-dd"));
            Console.WriteLine(alan.ToString("yyyy-mm-dd")); // دقیقه


            List<string> names = new List<string>()
            {
                "AAA", "BBB","CCC","ABC","abc","abd","ABCD","CBA","ABCdE","ABCDEF G"
            };

            foreach (var item in names)
            {
                //     Console.WriteLine(item);
            }


            foreach (var item in names)
            {
                //if (item.Contains("D"))
                //{
                //    Console.WriteLine(item);
                //}

                //if (item.ToUpper().Contains("D"))
                //{
                //    Console.WriteLine(item);
                //}

                if (item.ToLower().Contains("d"))
                {
                    // Console.WriteLine(item);
                }
            }


            var result = names.FindAll(n => n.ToUpper().StartsWith("A"));

            var result2 = names.FindAll(n => n.ToUpper().EndsWith("A"));

            var result3 = names.FindAll(n => n.Length > 3);

            var result4 = names.FindAll(n => n.Length > 3 && n.ToLower().Contains("e"));

            var result5 = names.FindAll(n => n.Length > 3 || n.ToLower().Contains("e"));

            var result6 = names.FindAll(n => n.Contains(" "));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }


            string name = "Soroush Sadr";
            char[] arrayResult = name.ToCharArray();
            foreach (char item in arrayResult)
            {
                Console.WriteLine(item);
            }




            Console.ReadKey();
        }
    }
}
