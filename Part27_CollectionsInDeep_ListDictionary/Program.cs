using System;
using System.Collections;
using System.Collections.Specialized;

namespace Part27_CollectionsInDeep_ListDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implements IDictionary using a singly linked list.
            //Recommended for collections that typically
            //include fewer than 10 items.

            Console.ForegroundColor = ConsoleColor.Green;

            var myListDic = new ListDictionary
            {
                { "Braeburn Apples", "1.49" },
                { "Fuji Apples", "1.29" },
                { "Gala Apples", "1.49" },
                { "Golden Delicious Apples", "1.29" },
                { "Granny Smith Apples", "0.89" },
                { "Red Delicious Apples", "0.99" }
            };

            // Display the contents of the collection using foreach. This is the preferred method.
            Console.WriteLine("Displays the elements using foreach:");
            PrintKeysAndValues1(myListDic);

            // Display the contents of the collection using the enumerator.
            Console.WriteLine("Displays the elements using the IDictionaryEnumerator:");
            PrintKeysAndValues2(myListDic);

            // Display the contents of the collection using the Keys, Values, Count, and Item properties.
            Console.WriteLine("Displays the elements using the Keys, Values, Count, and Item properties:");
            PrintKeysAndValues3(myListDic);

            // Copies the ListDictionary to an array with DictionaryEntry elements.
            DictionaryEntry[] myArr = new DictionaryEntry[myListDic.Count];
            myListDic.CopyTo(myArr, 0);

            // Displays the values in the array.
            Console.WriteLine("Displays the elements in the array:");
            Console.WriteLine("   KEY                       VALUE");
            for (int i = 0; i < myArr.Length; i++)
                Console.WriteLine("   {0,-25} {1}", myArr[i].Key, myArr[i].Value);
            Console.WriteLine();

            // Searches for a key.
            if (myListDic.Contains("Kiwis"))
                Console.WriteLine("The collection contains the key \"Kiwis\".");
            else
                Console.WriteLine("The collection does not contain the key \"Kiwis\".");
            Console.WriteLine();

            // Deletes a key.
            myListDic.Remove("Plums");
            Console.WriteLine("The collection contains the following elements after removing \"Plums\":");
            PrintKeysAndValues1(myListDic);

            // Clears the entire collection.
            myListDic.Clear();
            Console.WriteLine("The collection contains the following elements after it is cleared:");
            PrintKeysAndValues1(myListDic);

            Console.ReadKey();
            Console.ReadKey();


        }

        // Uses the foreach statement which hides the complexity of the enumerator.
        // NOTE: The foreach statement is the preferred way of enumerating the contents of a collection.
        public static void PrintKeysAndValues1(IDictionary myCol)
        {
            Console.WriteLine("   KEY                       VALUE");
            foreach (DictionaryEntry de in myCol)
                Console.WriteLine("   {0,-25} {1}", de.Key, de.Value);
            Console.WriteLine();
            Console.ReadKey();
        }


        // Uses the enumerator. 
        // NOTE: The foreach statement is the preferred way of enumerating the contents of a collection.
        public static void PrintKeysAndValues2(IDictionary myCol)
        {
            IDictionaryEnumerator myEnumerator = myCol.GetEnumerator();
            Console.WriteLine("   KEY                       VALUE");

            while (myEnumerator.MoveNext())
                Console.WriteLine("   {0,-25} {1}", myEnumerator.Key, myEnumerator.Value);

            Console.WriteLine();
        }

        // Uses the Keys, Values, Count, and Item properties.
        public static void PrintKeysAndValues3(ListDictionary myCol)
        {
            String[] myKeys = new String[myCol.Count];

            myCol.Keys.CopyTo(myKeys, 0);

            Console.WriteLine("   INDEX KEY                       VALUE");
            for (int i = 0; i < myCol.Count; i++)
                Console.WriteLine("   {0,-5} {1,-25} {2}", i, myKeys[i], myCol[myKeys[i]]);
            Console.WriteLine();
        }
    }
}
