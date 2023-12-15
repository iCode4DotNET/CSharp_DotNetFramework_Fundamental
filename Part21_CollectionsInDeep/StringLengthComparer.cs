using System.Collections.Generic;

namespace Part21_CollectionsInDeep
{
    /// <summary>
    /// یک کلاس دلخواه برای مشخص کردن نحوه ی مرتب سازی آرایه
    /// که اینترفیس مورد نظر را پیاده سازی کرده است
    /// </summary>
    public class StringLengthComparer : IComparer<string>
    {
        
        public int Compare(string x, string y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
