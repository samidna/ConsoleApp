using Global.Business.DTOs.EmployeeDto;
using Global.Business.Exceptions;
using Global.Business.Helpers;
using Global.Business.Interfaces;
using Global.Core.Entities;
using Global.DataAccess.Contexts;
using Global.DataAccess.Implementations;

namespace Global.Business.Services;

public class EmployeeService : IEmployeeService
{
    public EmployeeRepository employeeRepository { get; }
    public DepartmentRepository departmentRepository { get; }
    public EmployeeService()
    {
        employeeRepository = new EmployeeRepository();
        departmentRepository = new DepartmentRepository();
    }
    public void Create(EmployeeCreateDto employeeCreateDto)
    {
        var name = employeeCreateDto.name.Trim();
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new NullReferenceException();
        }
        if (!name.IsOnlyLetters())
        {
            throw new NotValidWordException(Helper.Errors["NotValidWordException"]);
        }
        var surname = employeeCreateDto.surname.Trim();
        if (!string.IsNullOrWhiteSpace(surname))
        {
            if (!surname.IsOnlyLetters())
            {
                throw new NotValidWordException(Helper.Errors["NotValidWordException"]);
            }
        }
        var department = departmentRepository.GetByName(employeeCreateDto.departmentName.Trim());
        if (department == null)
        {
            throw new NotFoundException($"{employeeCreateDto.departmentName} - doesn't exist");
        }
        var count = employeeRepository.GetAllByDepartmentId(department.DepartmentId).Count;
        if (count >= department.EmployeeLimit)
        {
            throw new CapacityNotEnoughException(Helper.Errors["CapacityNotEnoughException"]);
        }
        Employee employee = new(name, surname, employeeCreateDto.salary, employeeCreateDto.departmentName);
        employeeRepository.Add(employee);
    }
    public void Delete(int id)
    {
        var employee = DbContext.Employees.Find(emp => emp.EmployeeId == id);
        if (employee != null)
        {
            employeeRepository.Delete(employee);
        }
        else
        {
            throw new NotValidNumberException(Helper.Errors["NotValidNumberException"]);
        }
    }
    public List<Employee> GetAll(int skip, int take)
    {
        return DbContext.Employees.FindAll(emp => emp.EmployeeId <= take && emp.EmployeeId >= skip);
    }
    public List<Employee> GetByDepartment(string departmentName)
    {
        var dep = DbContext.Departments.Find(dep => dep.DepartmentName == departmentName);
        if (dep == null)
        {
            throw new NotFoundException("This Department doesn't exist");
        }
        return DbContext.Employees.FindAll(emp => emp.DepartmentName == departmentName);
    }

    public Employee GetEmployeeById(int id)
    {
        var count = DbContext.Employees.Count(emp => emp.EmployeeId == id);
        if (count < id)
        {
            throw new NotFoundException("This Id doesn't exist");
        }
        return DbContext.Employees.Find(emp => emp.EmployeeId == id);
    }
    public List<Employee> GetEmployeeByName(string name)
    {
        var tempname = employeeRepository.GetByName(name);
        if (tempname == null)
        {
            throw new NotFoundException("This employee was not found");
        }
        return DbContext.Employees.FindAll(emp => emp.EmployeeName == name);
    }
    public void Update(int id, EmployeeCreateDto employeeCreateDto)
    {
        var employee = DbContext.Employees.Find(emp => emp.EmployeeId == id);
        if (employee != null)
        {
            employee.EmployeeName = employeeCreateDto.name;
            employee.EmployeeSurname = employeeCreateDto.surname;
            employee.Salary = employeeCreateDto.salary;
            employee.DepartmentName = employeeCreateDto.departmentName;
        }
        else
        {
            throw new NotFoundException("This Id wasn't found");
        }
    }
    public void UpdateEmployeeSalary(int id, double salary)
    {
        var employee = DbContext.Employees.Find(emp => emp.EmployeeId == id);
        if (employee != null)
        {
            employee.Salary = salary;
        }
        else
        {
            throw new NotFoundException("This Id wasn't found");
        }
    }
    public void EmployeeTransfer(int id, string departmentName)
    {
        var emp = employeeRepository.Get(id);
        var dep = DbContext.Departments.Find(dep => dep.DepartmentName == departmentName);
        if (emp != null)
        {
            emp.DepartmentName = departmentName;
        }
        else
        {
            throw new NotFoundException("This Id wasn't found");
        }
        if (dep == null)
        {
            throw new NotFoundException("This department name wasn't found");
        }
    }
}

