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
    public Employee(double salary, string name, string surname, string departamentId)
    {
        EmployeeId = _id;
        _id++;
    }

    public Employee(string name,string surname,int departamentId,int salary):this()
    {
        Name = name;
        Surname = surname;
        DepartamentId = departamentId;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"id{EmployeeId} name{Name} surname:{Surname}";
    }
}
