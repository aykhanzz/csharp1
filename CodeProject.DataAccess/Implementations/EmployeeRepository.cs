using CodeProject.Core.Entities;
using CodeProject.DataAccess.Contexts;

namespace CodeProject.DataAccess.Implementations;

public class EmployeeRepository : IRepository<Employee>
{
    public void Add(Employee entity)
    {
        DBContexts.Employees.Add(entity);
    }

    public void Delete(Employee entity)
    {
        DBContexts.Employees.Remove(entity);
    }
    public void Update(Employee entity)
    {
        Employee? empl = DBContexts.Employees.Find(emp => emp.EmployeeId == entity.EmployeeId);
        empl.Name = entity.Name;
        empl.Name = entity.Surname;
    }

    public Employee Get(int id)
    {
        return DBContexts.Employees.Find(emp => emp.EmployeeId == id);
    }

    public List<Employee> GetAll()
    {
        return DBContexts.Employees;
    }
}
