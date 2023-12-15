using System.Collections.Generic;
using System;
using System.Linq;

namespace Part22_CollectionsInDeep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ 01 ]

            //the various ways of counting elements in an array

            string[] daysOfWeek = new string[] {
                                      "Monday",
                                      "Tuesday",
                                      "Wednesday",
                                      "Thursday",
                                      "Friday",
                                      "Saturday",
                                      "Sunday"
                                  };


            //  public interface ICollection<T> : IEnumerable<T>
            // ICollection<T>
            //  IEnumerable<T>  = You can iterate my elements !

            // ICollection<T> =  I know how many elements I have !
            //                   You can modify my contents !



            ICollection<string> collection = (ICollection<string>)daysOfWeek;

            // LINQ extension method
            Console.WriteLine("Count()  = " + collection.Count());

            // ICollection<T> property
            Console.WriteLine("Count  = " + collection.Count);

            // Array property
            Console.WriteLine("Length  = " + daysOfWeek.Length);

            #endregion

            #region [ 02 ]

            ICollection<string> collection2 = (ICollection<string>)daysOfWeek;

            // will throw an exception - Collection was of a fixed size , آرایه ها فیکس سایز هستند
            //collection2.Add("Alaki");


            // the correct way to use IsReadOnly

            if (collection2.IsReadOnly == false)
                collection2.Add("Another Day !");
            else
                Console.WriteLine("Collection is read-only");

            // but we can still replace elements!

            (collection2 as string[])[5] = "My Day!";

            foreach (string day in collection2)
                Console.WriteLine(day);


            #endregion


            //  daysOfWeek = new string[10];
            // Array.Resize<string>(ref daysOfWeek, 10);

            Array.Resize(ref daysOfWeek, 10);

            daysOfWeek[7] = "روز جدید";
            daysOfWeek[8] = "روز جدید";
            daysOfWeek[9] = "روز جدید";

            Console.ReadKey();
        }
    }
}
