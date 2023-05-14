using Global.Business.DTOs.EmployeeDto;
using Global.Core.Entities;

namespace Global.Business.Interfaces;

public interface IEmployeeService
{
    void Create(EmployeeCreateDto employeeCreateDto);
    void Delete(int id);
    void Update(int id, EmployeeCreateDto employeeCreateDto);
    List<Employee> GetAll(int skip,int take);
    List<Employee> GetEmployeeByName(string name);
    Employee GetEmployeeById(int id);
}
