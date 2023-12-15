using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

namespace Part26_CollectionsInDeep_Dictionary
{
    class PeopleByYearDictionary : KeyedCollection<int, Person>
    {
        //کلید در این قسمت مشخص میشود
       
        protected override int GetKeyForItem(Person item)
        {
            return item.BirthYear;
        }
    }



    class UncasedStringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            // چه به حرف بزرگ چه به حرف کوچک تبدیل شدند
            return x.ToUpper() == y.ToUpper();
        }

        public int GetHashCode(string obj)
        {
            int code = obj.ToUpper().GetHashCode();
            return code;
        }
    }


    class UncasedStringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
        }
    }

    class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.BirthYear.CompareTo(y.BirthYear);
        }
    }
}