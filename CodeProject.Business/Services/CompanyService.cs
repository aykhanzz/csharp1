using CodeProject.Business.Exceptions;
using CodeProject.Business.Helpers;
using CodeProject.Business.Interfaces;
using CodeProject.Core.Entities;
using CodeProject.DataAccess.Implementations;

namespace CodeProject.Business.Services;

public class CompanyService : ICompanyServices
{
    public CompanyRepository companyRepository { get; }
    public CompanyService()
    {
        companyRepository = new CompanyRepository();
    }
    public void Create(string companyName)
    {
        var equal = companyRepository.GetByName(companyName);
        if(equal != null)
        {
            throw new AlreadyEqualExceptions(Helper.Errors["AlreadyEqualException"]);
        }
        string name = companyName.Trim();
        if(name.Length <= 2 ) 
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }
        Company company = new Company(name);
        companyRepository.Add(company);
    }

    public void Delete(string companyName)
    {
        throw new NotImplementedException();
    }

    public List<Company> GetAll()
    {
        throw new NotImplementedException();
    }

    public Company GetById(int id)
    {
        throw new NotImplementedException();
    }
}
