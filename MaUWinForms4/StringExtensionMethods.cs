namespace MaUWinForms4
{
    /// <summary>
    /// String Method for checking if strings are not null or empty
    /// </summary>
    public static class StringExtentionMethods
    {
        public static bool IsNotNullOrEmpty(this string text)
        {
            return !string.IsNullOrEmpty(text);
        }
    }
}
