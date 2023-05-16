
namespace CodeProject.Business.Helpers;

public static class Helper
{
    public static Dictionary<string, string> Errors = new Dictionary<string, string>
    {
        { "AlreadyEqualException","This object already equal" },
        { "SizeException","Length doesn't match" },
        { "NullDataException","You must give data" },
        { "MinSalaryException","Salary can't be less than minimum income" },
        { "EmployeeLimitException","You are exceeded the employee limit"},
    };
}


//ve saire.