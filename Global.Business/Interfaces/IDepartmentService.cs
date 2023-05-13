using Global.Core.Entities;

namespace Global.Business.Interfaces;

public interface IDepartmentService
{
    void Create(string departmentName,string companyName,int employeeLimit);
    void Delete(string departmentName);
    void Update(int id, int employeeLimit);
    Department GetByName(string departmentName);
    Department GetById(int id);
    List<Department> GetAll();  
}
