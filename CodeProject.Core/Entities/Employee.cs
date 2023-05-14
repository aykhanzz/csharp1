using CodeProject.Core.Interface;

namespace CodeProject.Core.Entities;

public class Employee:IEntity
{
    private static int _id;
    public int EmployeeId { get; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public double Salary { get; set; }
    public int DepartamentId { get; set; }
    public Employee()
    {
        EmployeeId = _id;
        _id++;
    }

    public Employee(string name,string surname):this()
    {
        Name = name;
        Surname = surname;
    }

    public override string ToString()
    {
        return $"id{EmployeeId} name{Name} surname:{Surname}";
    }
}
