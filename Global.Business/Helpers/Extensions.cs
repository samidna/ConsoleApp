using System.Text.RegularExpressions;

namespace Global.Business.Helpers;

public static class Extensions
{
    public static bool IsOnlyLetters(this string value)
    {
        return Regex.IsMatch(value, @"^[a-zA-Z]+$");
    }
}
