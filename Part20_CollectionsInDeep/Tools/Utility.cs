namespace Part20_CollectionsInDeep.Tools
{
    internal class Utility
    {

        /// <summary>
        /// اسامی روز های هفته رو جمع میبندد
        /// </summary>
        /// <param name="daysOfWeek">روز های هفته</param>
        internal static void MakeDaysPlural(string[] daysOfWeek)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                daysOfWeek[i] += "s";
            }
        }


        /// <summary>
        /// this won't compile - 
        /// Cannot assign to 'day' because it is a 'foreach iteration variable'
        /// </summary>
        /// <param name="daysOfWeek"></param>
        static void MakeDaysPlural2(string[] daysOfWeek)
        {
            foreach (string item in daysOfWeek)
            {
                //item += 's';
            }
        }
    }
}
