using Global.Business.Exceptions;
using Global.Business.Helpers;
using Global.Business.Interfaces;
using Global.Core.Entities;
using Global.DataAccess.Contexts;
using Global.DataAccess.Implementations;
using System.Xml.Linq;

namespace Global.Business.Services;

public class DepartmentService : IDepartmentService
{
    public DepartmentRepository departmentRepository { get; }
    public CompanyRepository companyRepository { get; }
    public DepartmentService()
    {
        departmentRepository = new DepartmentRepository();
        companyRepository = new CompanyRepository();
    }
    public void Create(string departmentName, string Name, int employeeLimit)
    {
        var name = departmentName.Trim();
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new NullReferenceException();
        }
        if (departmentRepository.GetByName(name) != null)
        {
            throw new AlreadyExistException(Helper.Errors["AlreadyExistException"]);
        }
        var companyName = companyRepository.GetByName(Name);
        if (companyName == null)
        {
            throw new NotFoundException($"{Name} - doesn't exist");
        }
        if (employeeLimit < 10)
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }
        Department department = new Department(departmentName, employeeLimit, companyName.CompanyId);
        departmentRepository.Add(department);
    }

    public void Delete(string departmentName)
    {
        throw new NotImplementedException();
    }

    public List<Department> GetAll()
    {
        return DbContext.Departments;
    }

    public Department GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Department GetByName(string departmentName)
    { 
        return DbContext.Departments.Find(dep => dep.DepartmentName ==departmentName );
    }

    public void Update(int id, int employeeLimit)
    {
        throw new NotImplementedException();
    }
}
