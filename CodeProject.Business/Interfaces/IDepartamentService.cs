using CodeProject.Core.Entities;

namespace CodeProject.Business.Interfaces;

public interface IDepartamentService
{
    void Create(string departamentName, string companyName, int employeeLimit);
    void Delete(string departamentName);
    void Update(int id, int employeeLimit);
    Departament GetByName(string departamentName);
    Departament GeyById(int id);
    List<Departament> GetAll();
}
