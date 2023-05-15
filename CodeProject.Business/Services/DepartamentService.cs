using CodeProject.Business.Exceptions;
using CodeProject.Business.Helpers;
using CodeProject.Business.Interfaces;
using CodeProject.Core.Entities;
using CodeProject.DataAccess.Implementations;

namespace CodeProject.Business.Services;

public class DepartamentService : IDepartamentService
{
    public DepartmentRepository departmentRepository { get; }
    public CompanyRepository companyRepository { get; }
    public DepartamentService()
    {
        departmentRepository = new DepartmentRepository();
        companyRepository = new CompanyRepository();
    }
    public void Create(string departamentName, string companyName, int employeeLimit)
    {
        var name = departamentName.Trim();
        if(string.IsNullOrWhiteSpace(name))
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }
        if(departmentRepository.GetByName(name) != null)
        {
            throw new AlreadyEqualExceptions(Helper.Errors["AlreadyEqualException"]);
        }
        var company = companyRepository.GetByName(name);
        if(company == null)
        {
            throw new NotFoundException($"{name} - doesn't equal");
        }
        if (employeeLimit <= 3) 
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }
        Departament departament = new Departament(departamentName,company.CompanyId);
        departmentRepository.Add(departament);
    }


public void Delete(string departamentName)
{
    throw new NotImplementedException();
}

public List<Departament> GetAll()
{
    throw new NotImplementedException();
}

public Departament GetByName(string departamentName)
{
    throw new NotImplementedException();
}

public Departament GeyById(int id)
{
    throw new NotImplementedException();
}

public void Update(int id, int employeeLimit)
{
    throw new NotImplementedException();
}
}
