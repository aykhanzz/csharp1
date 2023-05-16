namespace CodeProject.Business.Exceptions;

public class EmployeeLimitException : Exception
{
    public EmployeeLimitException(string message) : base(message)
    {

    }
}
