using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part11.Classes
{
   public class MyClass
    {
        
        //public static int[] ChangeArray(int[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] += 10000;
        //    }
        //    return array;
        //}


        public static void ChangeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 20000;
            }
        }
    }
}
