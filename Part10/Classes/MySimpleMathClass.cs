using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Part10.Classes
{
    /// <summary>
    /// کلاسی برای عملیات پایه ریاضی
    /// </summary>
    class MySimpleMathClass
    {
        /// <summary>
        /// متدی برای جمع 2 عدد
        /// </summary>
        /// <param name="number1">عدد اول</param>
        /// <param name="number2">عدد دوم</param>
        /// <returns></returns>
       public static int DoSum(int number1, int number2)
        {
            // int sum = number1 + number2;
            // return sum;

            return number1 + number2;
        }

        //---------- Overloading

        /// <summary>
        /// متدی برای جمع 2 عدد
        /// </summary>
        /// <param name="number1">عدد اول</param>
        /// <param name="number2">عدد دوم</param>
        /// <returns></returns>
        public static float DoSum(float number1, float number2)
        {
            return number1 + number2;
        }


        /// <summary>
        /// متدی برای جمع 2 عدد
        /// </summary>
        /// <param name="number1">عدد اول</param>
        /// <param name="number2">عدد دوم</param>
        /// <returns></returns>
        public static float DoSum(int number1, float number2)
        {
            return number1 + number2;
        }
    }
}
