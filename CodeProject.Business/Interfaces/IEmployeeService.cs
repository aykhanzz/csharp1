using CodeProject.Business.DTOs.EmployeeDto;
using CodeProject.Core.Entities;

namespace CodeProject.Business.Interfaces;

public interface IEmployeeService
{
    void Create(EmployeeCreateDto employeeCreateDto);
    void Delete(int id);
    void Update(int id, EmployeeCreateDto employeeCreateDto);
    List<Employee> GetAll(int skip,int take);
    List<Employee> GetEmployeeByDepartamentId(int id);
    List<Employee> GetEmployeeByName(string name);
    Employee GetEmployeeById(int id);
}
