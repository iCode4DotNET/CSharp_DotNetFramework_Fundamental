namespace Part23_CollectionsInDeep.Models
{
    /// <summary>
    /// کلاس ماشین
    /// </summary>
    public class Car
    {
        public Car(string make, int year)
        {
            Brand = make;
            Year = year;
        }

        /// <summary>
        /// سال
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// ساخت
        /// </summary>
        public string Brand { get; set; }

        public override string ToString()
        {
            return string.Format($"Make = {Brand} , Year = {Year}");
        }
    }

}