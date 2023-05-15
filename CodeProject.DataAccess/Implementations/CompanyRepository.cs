﻿using CodeProject.Core.Entities;
using CodeProject.DataAccess.Contexts;

namespace CodeProject.DataAccess.Implementations;

public class CompanyRepository : IRepository<Company>
{
    public void Add(Company entity)
    {
        DBContexts.Companies.Add(entity);
    }

    public void Delete(Company entity)
    {
        DBContexts.Companies.Remove(entity);
    }
    public void Update(Company entity)
    {
        Company com = DBContexts.Companies.Find(c => c.CompanyId == entity.CompanyId);
        com.CompanyName = entity.CompanyName;
    }

    public Company? Get(int id)
    {
        return DBContexts.Companies.Find(c => c.CompanyId == id);
    }

    public Company? GetByName(string name)
    {
        return DBContexts.Companies.Find(c => c.CompanyName == name);
    }

    public List<Company> GetAll()
    {
        return DBContexts.Companies;
    }

    public List<Company> GetAllByName(string name)
    {
        return DBContexts.Companies.FindAll(c=> c.CompanyName == name);
    }
}
