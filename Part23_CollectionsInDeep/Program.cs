using Part23_CollectionsInDeep.Models;
using System;

namespace Part23_CollectionsInDeep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // foreach statement cannot operate on variables
            // of type Car
            // because Car does not contain a
            // public definition
            // for 'GetEnumerator'

            //Car car1 = new Car("aaaa", 2000);
            //foreach (Car item in car1){}


            Cars2 cars2 = new Cars2();
            foreach (var car in cars2) 
            {
                Console.WriteLine(car);
            }


            //Cars cars = new Cars();
            //foreach (var item in cars)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
    }
}
