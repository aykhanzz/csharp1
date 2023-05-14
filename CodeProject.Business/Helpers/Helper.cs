
namespace CodeProject.Business.Helpers;

public static class Helper
{
    public static Dictionary<string, string> Errors = new Dictionary<string, string>
    {
        { "AlreadyEqualException","This object already equal" },
        { "SizeException","Length doesn't match" }
    };
}