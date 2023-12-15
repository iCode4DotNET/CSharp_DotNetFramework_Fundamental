using System;
using System.Collections;
using System.Collections.Specialized;

namespace Part28_CollectionsInDeep_HybridDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implements IDictionary by using a ListDictionary
            // while the collection is small,
            // and then switching to a Hashtable when the collection gets large.

            var myCol = new HybridDictionary
            {
                { "Braeburn Apples", "1.49" },
                { "Fuji Apples", "1.29" },
                { "Gala Apples", "1.49" },
                { "Golden Delicious Apples", "1.29" },
                { "Granny Smith Apples", "0.89" },
                { "Red Delicious Apples", "0.99" },
                { "Plantain Bananas", "1.49" },
                { "Yellow Bananas", "0.79" },
                { "Strawberries", "3.33" },
                { "Cranberries", "5.98" },
                { "Navel Oranges", "1.29" },
                { "Grapes", "1.99" },
                { "Honeydew Melon", "0.59" },
                { "Seedless Watermelon", "0.49" },
                { "Pineapple", "1.49" },
                { "Nectarine", "1.99" },
                { "Plums", "1.69" },
                { "Peaches", "1.99" }
            };

            // Display the contents of the collection using foreach. This is the preferred method.
            Console.WriteLine("Displays the elements using foreach:");
            PrintKeysAndValues1(myCol);

            // Display the contents of the collection using the enumerator.
            Console.WriteLine("Displays the elements using the IDictionaryEnumerator:");
            PrintKeysAndValues2(myCol);

            // Display the contents of the collection using the Keys, Values, Count, and Item properties.
            Console.WriteLine("Displays the elements using the Keys, Values, Count, and Item properties:");
            PrintKeysAndValues3(myCol);

            // Copies the HybridDictionary to an array with DictionaryEntry elements.
            DictionaryEntry[] myArr = new DictionaryEntry[myCol.Count];
            myCol.CopyTo(myArr, 0);

            // Displays the values in the array.
            Console.WriteLine("Displays the elements in the array:");
            Console.WriteLine("   KEY                       VALUE");
            for (int i = 0; i < myArr.Length; i++)
                Console.WriteLine("   {0,-25} {1}", myArr[i].Key, myArr[i].Value);
            Console.WriteLine();

            // Searches for a key.
            if (myCol.Contains("Kiwis"))
                Console.WriteLine("The collection contains the key \"Kiwis\".");
            else
                Console.WriteLine("The collection does not contain the key \"Kiwis\".");
            Console.WriteLine();

            // Deletes a key.
            myCol.Remove("Plums");
            Console.WriteLine("The collection contains the following elements after removing \"Plums\":");
            PrintKeysAndValues1(myCol);

            // Clears the entire collection.
            myCol.Clear();
            Console.WriteLine("The collection contains the following elements after it is cleared:");
            PrintKeysAndValues1(myCol);


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
        public static void PrintKeysAndValues3(HybridDictionary myCol)
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
