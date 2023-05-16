using CodeProject.Core.Entities;
using CodeProject.DataAccess.Contexts;
using CodeProject.DataAccess.Interfaces;

namespace CodeProject.DataAccess.Implementations;

public class DepartmentRepository : IRepository<Departament>
{
    public void Add(Departament entity)
    {
        DBContexts.Departaments.Add(entity);
    }

    public void Delete(Departament entity)
    {
        DBContexts.Departaments.Remove(entity);
    }
    public void Update(Departament entity)
    {
        Departament dep = DBContexts.Departaments.Find(emp => emp.DepartamentId == entity.DepartamentId);
        dep.EmployeeLimit = entity.EmployeeLimit;
        dep.DepartamentName = entity.DepartamentName;
    }
    public Departament? Get(int id)
    {
        return DBContexts.Departaments.Find(d=>d.DepartamentId == id);
    }

    public List<Departament> GetAll()
    {
        return DBContexts.Departaments;
    }
    public Departament GetByName(string name)
    {
        return DBContexts.Departaments.Find(d => d.DepartamentName == name);
    }

    public List<Departament> GetAllByName(string name)
    {
        return DBContexts.Departaments.FindAll(d => d.DepartamentName == name);
    }

}
