using Global.Core.Entities;
using Global.Core.Interfaces;
using Global.DataAccess.Contexts;
using Global.DataAccess.Interfaces;
using System.Xml.Linq;

namespace Global.DataAccess.Implementations;

public class EmployeeRepository : IRepository<Employee>
{
    public void Add(Employee entity)
    {
        DbContext.Employees.Add(entity);
    }

    public void Delete(Employee entity)
    {
        DbContext.Employees.Remove(entity);
    }

    public void Update(Employee entity)
    {
        Employee emp = DbContext.Employees.Find(emp => emp.EmployeeId == entity.EmployeeId);
        emp.EmployeeName = entity.EmployeeName;
        emp.EmployeeSurname = entity.EmployeeSurname;
    }
    public Employee? Get(int id)
    {
        return DbContext.Employees.Find(emp => emp.EmployeeId == id);
    }
    public List<Employee> GetAll()
    {
        return DbContext.Employees;
    }

    public Employee? GetByName(string name)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetAllByName(string name)
    {
        return DbContext.Employees.FindAll(emp => emp.EmployeeName == name);
    }
    public List<Employee> GetAllByDepartmentId(int id)
    {
        return DbContext.Employees.FindAll(emp => emp.DepartmentId == id);
    }
}
