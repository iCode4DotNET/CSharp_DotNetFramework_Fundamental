namespace Part26_CollectionsInDeep_Dictionary
{
    /// <summary>
    /// کلاس اشخاص
    /// </summary>
    public class Person
    {
        /// <summary>
        /// سازنده
        /// </summary>
        /// <param name="name">نام</param>
        /// <param name="birthYear">سال تولد</param>
        public Person(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }

        /// <summary>
        /// سال تولد
        /// </summary>
        public int BirthYear { get; set; }

        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }

        public override string ToString()
        {
            return Name + " - " + BirthYear;
        }

    }
}