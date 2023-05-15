using Global.Core.Entities;

namespace Global.Business.Interfaces;

public interface IDepartmentService
{
    void Add(Employee employee, string departmentName);
    void Create(string departmentName,string companyName,int employeeLimit);
    void Delete(string departmentName);
    void UpdateDepartment(string name,string newname, int employeeLimit);
    Department GetByName(string departmentName);
    Department GetById(int id);
    List<Department> GetAll();  
}
