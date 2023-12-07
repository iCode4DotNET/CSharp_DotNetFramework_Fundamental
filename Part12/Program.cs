using Part12.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;

            MyClass.DoSomething(a);

            Console.WriteLine($"after method value = {a}");

            MyClass.DoSomething(ref a);

            Console.WriteLine($"after method value = {a}");


            int myOutVar = 12345;
            MyClass.DoSomething2(out myOutVar);

            int x1, x2;
            // Console.WriteLine($"x1 = {x1} , x2 = {x2}");
            MyClass.DoSomething2(out x1, out x2);
            Console.WriteLine($"x1 = {x1} , x2 = {x2}");

            //--------------------------------------------------

            int[] array = new int[] { 1, 2, 34, 5, 67, 8, 9, 10 };

            MyClass.ShowArrayValues(array);

            MyClass.ShowNumbers(array);

            MyClass.ShowNumbers(1, 2, 3, 4, 5);

            MyClass.ShowNumbers(10, 20, 30, 40);

            MyClass.ShowNumbers(100, 200, 300);

            MyClass.ShowNumbers(100, 200);

            MyClass.ShowNumbers(100, 200, 300,54,54,54,543,5,435,43,5,435,435,55);


            //----------------------------------------

            int res;
            int.TryParse("12234", out res);

            Console.ReadKey();
        }
    }
}
