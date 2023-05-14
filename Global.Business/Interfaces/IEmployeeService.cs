using Global.Business.DTOs.EmployeeDto;
using Global.Core.Entities;

namespace Global.Business.Interfaces;

public interface IEmployeeService
{
    void Create(EmployeeCreateDto employeeCreateDto);
    void Delete(int id);
    void Update(int id, EmployeeCreateDto employeeCreateDto);
    void UpdateEmployeeSalary(int id,double salary);
    void EmployeeTransfer(int id, string departmentName);
    List<Employee> GetAll(int skip,int take);
    List<Employee> GetEmployeeByName(string name);
    Employee GetEmployeeById(int id);
}
