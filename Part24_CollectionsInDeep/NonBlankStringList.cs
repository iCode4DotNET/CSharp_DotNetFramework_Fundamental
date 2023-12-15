using System;
using System.Collections.ObjectModel;

namespace Part24_CollectionsInDeep
{
    /// <summary>
    /// یک نوع داده ایی جدید و شخصی سازی شده برای کار با کالکشن های رشته ایی
    /// </summary>
    public sealed class NonBlankStringList : Collection<string>
    {
        // overload : چند متد با اسامی یکسان و امضاهای مختلف
        // override : عملکرد متد های ویرچوال به ارث رسیده را میتوان عوض کرد


        public override string ToString()
        {
            return "alaki";
        }

        protected override void InsertItem(int index, string item)
        {
            // اول شرط من رو چک کن اگر اکی بود همون کار قبلیت رو انجام بده

            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("Elements of NonBlankStringList Nabayad Khali Bashand!!");

            base.InsertItem(index, item); // هر کاری قبلن انجام میدادی الان هم انجام بده
        }

        protected override void SetItem(int index, string item)
        {
            // اول شرط من رو چک کن اگر اکی بود همون کار قبلیت رو انجام بده

            if (string.IsNullOrWhiteSpace(item))
                throw new ArgumentException("Elements of NonBlankStringList Nabayad Khali Bashand!!");

            base.SetItem(index, item); // هر کاری قبلن انجام میدادی الان هم انجام بده
        }
    }
}