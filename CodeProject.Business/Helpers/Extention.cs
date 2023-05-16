using System.Text.RegularExpressions;

namespace CodeProject.Business.Helpers;

public static class Extention
{
    public static bool IsOnlyLetters(this string value)
    {
        return Regex.IsMatch(value, @"^[a-zA-Z]+$");
    }
}
