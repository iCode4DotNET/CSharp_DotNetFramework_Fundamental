namespace SadrTools.Extension
{
    public static class StringExt 
    {
        /// <summary>
        /// حذف کاراکتر آخر
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveLastCharacter(this string str, int length = 1)
        {
            return str.Substring(0, str.Length - length);
        }
    }
}