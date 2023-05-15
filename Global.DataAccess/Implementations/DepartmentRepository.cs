using Global.Core.Entities;
using Global.DataAccess.Contexts;
using Global.DataAccess.Interfaces;

namespace Global.DataAccess.Implementations;

public class DepartmentRepository : IRepository<Department>
{
    public void Add(Department entity)
    {
        DbContext.Departments.Add(entity);  
    }
    public void Delete(Department entity)
    {
        DbContext.Departments.Remove(entity);   
    }
    public void Update(Department entity)
    {
        Department dep = DbContext.Departments.Find(dep => dep.DepartmentId == entity.DepartmentId);
        dep.DepartmentName = entity.DepartmentName;
        dep.EmployeeLimit = entity.EmployeeLimit;   
    }
    public Department? Get(int id)
    {
        return DbContext.Departments.Find(dep=>dep.DepartmentId==id);
    }
    public List<Department> GetAll()
    {
        return DbContext.Departments;
    }
    public Department? GetByName(string name)
    {
        return DbContext.Departments.Find(dep => dep.DepartmentName == name);
    }
    public List<Department> GetDepartmentsByCompany(int companyId)
    {
        return DbContext.Departments.FindAll(dep => dep.CompanyId == companyId);
    }
    public List<Employee> GetDepartmentEmployees(string departmentName)
    {
        return DbContext.Employees.FindAll(emp=>emp.DepartmentName==departmentName);
    }
    public List<Department> GetAllByName(string name)
    {
        return DbContext.Departments.FindAll(dep => dep.DepartmentName == name);
    }
}
