using System.Text.RegularExpressions;

namespace Simple.Extensions
{
    public static class StringExtensions
    {
        public static string DisplayName(this string name)
        {
            return string.IsNullOrEmpty(name) ? string.Empty : Regex.Replace(name, "(\\B[A-Z])", " $1");
        }
    }
}
