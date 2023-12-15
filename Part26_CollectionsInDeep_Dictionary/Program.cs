using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part26_CollectionsInDeep_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ 01 ]

            // جفت کلید مقدار

            try
            {
                Dictionary<string, Person> People = new Dictionary<string, Person>
                {
                    {"S.S", new Person("Soroush Sadr", 1984)},
                    {"A.A", new Person("Ali Alavi", 1979)},
                    //{"A.A", new Person("Amir Hasani", 1997)},
                    {"X.X", new Person(" ",2000) }
                };

                //'An item with the same key
                // has already been added.'

                //look up
                Person find = People["A.A"];

                // the given key was not present in dictionary
                // Person find22 = People["Alaki"];


                string keyToFind = "Alaki2";
                bool isFound = People.TryGetValue(keyToFind, out Person find2);

                if (isFound)
                {
                    Console.WriteLine(find2.ToString());
                }
                else
                {
                    Console.WriteLine("Not Found " + keyToFind);
                }

                People["X.X"] = new Person("X1 X2", 1990);
                People["Y.Z"] = new Person("Y1 Z1", 1990);
                People["Y.Z"] = new Person("Y1 Z1", 2090);


                People.Remove("X.X");

                People.Add("T.T", new Person("T1 T2", 2007));

                string s = "";
                foreach (var item in People)
                {
                    s += item.Key + " : " + item.Value + "\n";
                }

                var keys = People.Keys;

                var values = People.Values;




                Console.WriteLine(s);

                Console.ReadKey();


                Dictionary<string, Person> People2 = new Dictionary<string, Person>(StringComparer.CurrentCultureIgnoreCase)

            {
                {"S.S", new Person("Soroush Sadr", 1984)},
                {"A.A", new Person("Ali Alavi", 1979)},
                {"A.H", new Person("Amir Hasani", 1997)}
            };

                Console.WriteLine(People2["a.h"].Name);





                UncasedStringEqualityComparer obj = new UncasedStringEqualityComparer();

                Dictionary<string, Person> People3 = new Dictionary<string, Person>(obj)
            {
                {"S.S", new Person("Soroush Sadr", 1984)},
                {"A.A", new Person("Ali Alavi", 1979)},
                {"A.H", new Person("Amir Hasani", 1997)}
            };

                Console.WriteLine(People3["s.s"].Name);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            #endregion

            Console.Clear();


            #region [ 02 ]

            /*
            SortedList<string, Version> People4 = new SortedList<string, Person>()
            {
                {"XX", new Person("X1 X2", 1900)},
                {"AA", new Person("A1 A2 ", 1950)},
                {"ZZ", new Person("Z1 Z2", 1997)}
            };

            People4.Add("BB", new Person("B1 B2", 1990));

            string res = "";
            foreach (var pm in People4)
                res += pm.Key + " " + pm.Value + "\n";

            Console.WriteLine(res);
            */
            #endregion

            #region [ 03 ]

            PeopleByYearDictionary People6 = new PeopleByYearDictionary()
            {
                new Person("Soroush", 1900),
                new Person("Ali", 2000),
                new Person("Reza", 1997),
                new Person("Reza2", 1997)
            };

            People6.Add(new Person("John", 1990));

            var list = (IList<Person>)People6;

            Console.WriteLine("First Person is " + list[0]);

            Console.WriteLine("Reza is " + People6[1997]);

            string s2 = "";
            foreach (var pm in People6)
                s2 += pm + "\n";


            Console.WriteLine(s2);

            #endregion


            Console.ReadKey();
        }
    }
}
