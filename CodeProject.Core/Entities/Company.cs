using CodeProject.Core.Interface;

namespace CodeProject.Core.Entities;

public class Company:IEntity
{
    private static int _id;
    public int CompanyId { get; }
    public string CompanyName { get; set; }
    public Company()
    {
        CompanyId = _id;
        _id++;
    }

    public Company(string name) : this()
    {
        CompanyName = name;
    }
}
