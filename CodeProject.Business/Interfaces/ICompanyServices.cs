using CodeProject.Core.Entities;

namespace CodeProject.Business.Interfaces;

public interface ICompanyServices
{
    void Create(string companyName);
    void Delete(string companyName);
    Company GetById(int id);
    List<Company> GetAll();
}
