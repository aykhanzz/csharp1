using CodeProject.Business.DTOs.EmployeeDto;
using CodeProject.Business.Exceptions;
using CodeProject.Business.Helpers;
using CodeProject.Business.Interfaces;
using CodeProject.Core.Entities;
using CodeProject.DataAccess.Implementations;

namespace CodeProject.Business.Services;

public class EmployeeService : IEmployeeService
{

    public EmployeeRepository employeerepository { get; }
    public DepartmentRepository departmentRepository { get; }

    public EmployeeService()
    {
        employeerepository = new EmployeeRepository();
        departmentRepository = new DepartmentRepository();
    }



    public void Create(EmployeeCreateDto employeeCreateDto)
    {
        var name = employeeCreateDto.name.Trim();
        if (employeeCreateDto == null)
        {
            throw new NullDataException(Helper.Errors["NullDataException"]);
        }

        if(employeeCreateDto.Salary < 345)
        {
            throw new MinSalaryException(Helper.Errors["MinSalaryException, Minimum Salary is 345"]);
        }
        if(employeeCreateDto.name.Length < 3)
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }

        if(employeeCreateDto.name.IsOnlyLetters() && employeeCreateDto.surname.IsOnlyLetters())
        {
            throw new FormatException(Helper.Errors["FormatExeption"]);
        }
       









    public void Delete(int id)
    {
            if (id < 0)
            {
                throw new SizeException(Helper.Errors["SizeException"]);
            }
            var result = employeerepository.GetByName(name);
            if (result == null)
            {
                throw new NullDataException(Helper.Errors["NullDataException"]);)
            }
    emplo
    }

    public List<Employee> GetAll(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetEmployeeByDepartamentId(int id)
    {
        throw new NotImplementedException();
    }

    public Employee GetEmployeeById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetEmployeeByName(string name)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, EmployeeCreateDto employeeCreateDto)
    {
        throw new NotImplementedException();
    }
}
