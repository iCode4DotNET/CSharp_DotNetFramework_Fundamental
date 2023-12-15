using System.Collections;


namespace Part23_CollectionsInDeep.Models
{
    /// <summary>
    /// کلاس ماشین هاااااا
    /// </summary>
    public class Cars : IEnumerable//, IEnumerator
    {
        private readonly Car[] _carlist;

        private int _index = -1;

        public Cars()
        {
            _carlist = new Car[6]
            {
                 new Car("Ford",1992),
                 new Car("Fiat",1988),
                 new Car("Buick",1932),
                 new Car("Ford",1932),
                 new Car("Dodge",3000),
                 new Car("Honda",2000)
            };
        }

        public object Current => _carlist[_index];

        public object Current_Old_Fashion
        {
            get
            {
                return _carlist[_index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            _index++;
            return _carlist.Length > _index;
        }

        public void Reset()
        {
            _index = -1;
        }
    }

    public class Cars2 : IEnumerable, IEnumerator
    {
        private readonly Car[] _carlist;

        private int _index = -1;

        public Cars2()
        {
            _carlist = new Car[6]
            {
                 new Car("Ford",1992),
                 new Car("Fiat",1988),
                 new Car("Buick",1932),
                 new Car("Ford",1932),
                 new Car("Dodge",3000),
                 new Car("Honda",2000)
            };

        }

        public object Current
        {
            get
            {
                var car = _carlist[_index];
                return car;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            _index++;

            return _carlist.Length > _index;
        }

        public void Reset()
        {
            _index = -1;
        }
    }


    public sealed class Cars2000AndLaterList : System.Collections.ObjectModel.Collection<Car>
    {
        protected override void InsertItem(int index, Car item)
        {
            if (item.Year > 2000)
                base.InsertItem(index, item);
        }
    }
}