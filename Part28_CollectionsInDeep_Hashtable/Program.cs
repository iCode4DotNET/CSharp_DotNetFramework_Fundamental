using System;
using System.Collections;

namespace Part28_CollectionsInDeep_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For very large Hashtable objects,
            // you can increase the maximum capacity
            // to 2 billion elements on a 64-bit system by 
            // setting the enabled attribute of the
            // configuration element 
            // to true in the run-time environment.

            var openWith = new Hashtable
            {
                // Add some elements to the hash table. There are no 
                // duplicate keys, but some of the values are duplicates.
                { "txt", "notepad.exe" },
                { "bmp", "paint.exe" },
                { "dib", "paint.exe" },
                { "rtf", "wordpad.exe" }
            };

            // The Add method throws an exception if the new key is 
            // already in the hash table.
            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            // The Item property is the default property, so you 
            // can omit its name when accessing elements. 
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // The default Item property can be used to change the value
            // associated with a key.

            openWith["rtf"] = "winword.exe"; // ویرایش میکند



            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // If a key does not exist, setting the default Item property
            // for that key adds a new key/value pair.
            openWith["doc"] = "winword.exe";

            // ContainsKey can be used to test keys before inserting 
            // them.
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
            }

            // When you use foreach to enumerate hash table elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }

            // To get the values alone, use the Values property.
            ICollection valueColl = openWith.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for hash table values.
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            // To get the keys alone, use the Keys property.
            ICollection keyColl = openWith.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for hash table keys.
            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"doc\")");
            openWith.Remove("doc");

            if (!openWith.ContainsKey("doc"))
            {
                Console.WriteLine("Key \"doc\" is not found.");
            }


            Console.ReadKey();
        }
    }
}
