using System;
using System.Linq;
using System.Text;

namespace Part20_CollectionsInDeep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                                      "Monday",
                                      "Tuesday",
                                      "Wednesday",
                                      "Thursday",
                                      "Friday",
                                      "Saturday",
                                      "Sunday"
                                  };

            // foreach is fine for this
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            // this is best done using for, not foreach
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(daysOfWeek[i]);
            }

            foreach (string item in daysOfWeek)
            {
                // اگر بخوای فقط 3 روز اول را نمایش دهید باید مثلن از یک متغیر شمارنده استفاده کنید
            }


            // this is best done using for, not foreach
            var sb = new StringBuilder();

            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                sb.Append(daysOfWeek[i]);

                if (i < daysOfWeek.Length - 2)
                    sb.Append(", ");

                else if (i == daysOfWeek.Length - 2)
                    sb.Append(" and ");
            }

            Console.WriteLine(sb.ToString());


            Console.ReadKey();

            Tools.Utility.MakeDaysPlural(daysOfWeek);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }

            Console.ReadKey();

            var names = daysOfWeek.ToList();

            //Collection was modified; enumeration operation may not execute.
            foreach (var item in names)
            {
                //names.Remove(item);
                names.RemoveAt(3);
            }
        }
    }
}