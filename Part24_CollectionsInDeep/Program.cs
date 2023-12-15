using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Part24_CollectionsInDeep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region [ 01 ]

            var normalList = new List<string>()
            {
                "AAA",
                "BBB",
                "CCC",
                "DDD",
                "EEE"
            };

            normalList.Add("Soroush Sadr");

            // two different ways of getting read-only access to the list

            var copy = new ReadOnlyCollection<string>(normalList);// روش اول

            var copy2 = normalList.AsReadOnly(); // روش دوم
            
            var copy3 = normalList.AsReadOnly(); // روش دوم

            //BadCode(copy);

            RemoveIfNotReadonly(copy, 1);

            foreach (string item in normalList)
                Console.WriteLine(item);

            #endregion


            #region [ 02 ]


            var lst = new NonBlankStringList
            {
                "Item added at index 0"
            };

            // this line would throw an exception
            
            lst[0] = "   ";
            lst.Add("    ");
            lst.Insert(2, "Item inserted at index 2");




            foreach (string item in lst)
                Console.WriteLine(item);

            #endregion


            Console.ReadKey();
        }


        /// <summary>
        /// اندیس شماره 2 را حذف میکند
        /// </summary>
        /// <param name="lst">هرچیزی که اینترفیس آی لیست استرینگ را پیاده سازی کرده باشد</param>
        static void BadCode(IList<string> lst)
        {
            // this would throw an exception: lst is read-only
            lst.RemoveAt(2);
        }




        /// <summary>
        /// ایندکس ( از صفر شروع میشود ) مورد نظر را حذف میکند
        /// </summary>
        /// <param name="lst">ورودی</param>
        /// <param name="index">ایندکس با مقدار پیش فرض صفر</param>
        static void RemoveIfNotReadonly(IList<string> lst, int index = 0)
        {
            try
            {
                if (lst.IsReadOnly)
                    return; // بیخیال بقیه کد ها شو

                if (lst.Count == 0)
                    return; // بیخیال بقیه کد ها شو


                if (lst.Count <= index)
                    return; // ایندکس اشتباه است

                lst.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                lst.RemoveAt(0); // ممکنه خطرناک باشه
            }
        }


    }
}
