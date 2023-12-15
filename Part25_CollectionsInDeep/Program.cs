using System;
using System.Collections.Generic;

namespace Part25_CollectionsInDeep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Queue : First In First Out قانون صف
            // First Come , First Service
            // Last in Last Out

            //-------------------------

            // Stack : Last In First Out قانون پشته
            // First In Last Out
            // menu delete photo !! 


            #region [ 01 ]

            Stack<string> books = new Stack<string>();

            books.Push("Book 1"); // اضافه کردن آیتم به پشته
            books.Push("Book 2");
            books.Push("Book 3");
            books.Push("Book 4");

            string s = "ALL BOOKS:\n";
            foreach (string title in books)
                s += title + "\n";

            Console.WriteLine(s);

            Console.ReadKey();


            string topItem = books.Pop();

            s += "\nTop item is " + topItem;

            s += "\nALL BOOKS after popping:";
            foreach (string title in books)
                s += "\n" + title;

            Console.WriteLine(s);

            string topItemWithoutRemoving = books.Peek();

            Console.WriteLine("Peek : " + topItemWithoutRemoving);

            Console.ReadKey();

            #endregion

            #region [ 02 ]

            s = "";

            Queue<string> tasks = new Queue<string>();

            tasks.Enqueue("Task No 1");
            tasks.Enqueue("Task No 2");
            tasks.Enqueue("Task No 3");
            tasks.Enqueue("Task No 4");

            s = "ALL TASKS:\n";

            foreach (string title in tasks)
                s += title + "\n";

            Console.WriteLine(s);

            Console.ReadKey();

            string firstTask = tasks.Dequeue();
            string firstTaskWithoutRemoving = tasks.Peek();

            s += "\n\n\nFirst task is " + firstTask;

            s += "\n\n\nALL TASKS:";

            foreach (string title in tasks)
                s += "\n" + title;

            Console.WriteLine(s);

            Console.ReadKey();


            #endregion

            #region [ 03 ]

            // لیست های پیوندی
            // یک سری گره یا همان نود که بوسیله لینک هایی بهم متصل میشوند
            // ترتیب و نحوه وصل شدن گره ها به همدیگر کاملن دلخواه میباشد

            LinkedList<string> Names = new LinkedList<string>();

            Names.AddLast("AAA");
            Names.AddLast("BBB");
            Names.AddLast("CCC");
            Names.AddLast("DDD");
            Names.RemoveFirst();
          

            LinkedListNode<string> EEE = Names.AddFirst("EEE");


            LinkedListNode<string> findCCC = Names.Find("CCC");
            Names.AddAfter(findCCC, "C#");
           
            
            LinkedListNode<string> findAAA = Names.Find("AAA"); //null refrence
            if (findAAA != null)
            {
                var unknown = findAAA.Next.Next.Next.Next.Next.Next.Next;
            }
            else
            {
                var unknown = findCCC.Next.Next.Previous.Previous.Previous;
            }

            s = "";
            foreach (string item in Names)
                s += item + "\n";

            Console.WriteLine(s);

            #endregion

            Console.ReadKey();
        }
    }
}
