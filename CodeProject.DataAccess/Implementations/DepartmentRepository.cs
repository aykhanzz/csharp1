using CodeProject.Core.Entities;
using CodeProject.DataAccess.Contexts;

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
        Departament dep = DBContexts.Departaments.Find(dep => dep.DepartamentId == entity.DepartamentId);
        dep.EmployeeLimit = entity.EmployeeLimit;
        dep.DepartamentName = entity.DepartamentName;
    }
    public Departament? Get(int id)
    {
        return DBContexts.Departaments.Find(dep=>dep.DepartamentId == id);
    }

    public Company? GetByName(string com)
    {
        return DBContexts.Companies.Find(c => c.CompanyName == com);
    }

    public List<Departament> GetAll()
    {
        return DBContexts.Departaments;
    }

}
