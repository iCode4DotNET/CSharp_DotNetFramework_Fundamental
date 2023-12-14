using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Part19_Compare_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // boxing - unboxing
            const long SIZE = 100_000_000;

            int[] MyClassicArray = new int[SIZE];
            ArrayList MyArrayList = new ArrayList();
            List<int> MyGenericList = new List<int>();


            /* PLZ DONT TRY THIS WAY !!!
            StopWatch watch = new StopWatch();
            watch.F1();
            */

            Stopwatch sw1 = new Stopwatch();
            Stopwatch sw2 = new Stopwatch();
            Stopwatch sw3 = new Stopwatch();

            sw1.Start();
            for (int i = 0; i < SIZE; i++)
            {
                MyClassicArray[i] = i;
            }
            sw1.Stop();

            Console.WriteLine($"Classic array with size {SIZE} = {sw1.ElapsedMilliseconds}");


            sw2.Start();
            for (int i = 0; i < SIZE; i++)
            {
                MyArrayList.Add(i);
            }
            sw2.Stop();

            Console.WriteLine($"Array List with size {SIZE} = {sw2.ElapsedMilliseconds}");


            sw3.Start();
            for (int i = 0; i < SIZE; i++)
            {
                MyGenericList.Add(i);
            }
            sw3.Stop();

            Console.WriteLine($"Generic List with size {SIZE} = {sw3.ElapsedMilliseconds}");


            


            Console.ReadKey();

        }
    }
}
