using CodeProject.Core.Interface;
using System.Xml.Linq;

namespace CodeProject.Core.Entities;

public class Departament:IEntity
{
    private static int _id;
    public int DepartamentId { get; }
    public string DepartamentName { get; set; }
    public static int CompanyId { get; set; }
    public int EmployeeLimit { get; set; }

    public Departament()
    {
        DepartamentId = _id;
        _id++;
    }

    public Departament(string name) : this()
    {
        DepartamentName = name;
    }
    public override string ToString()
    {
        return $"name{DepartamentName} Id:{DepartamentId}";
    }
}
