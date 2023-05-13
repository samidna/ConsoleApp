﻿using Global.Business.DTOs.EmployeeDto;
using Global.Business.Exceptions;
using Global.Business.Helpers;
using Global.Business.Interfaces;
using Global.Core.Entities;
using Global.DataAccess.Implementations;
using System.Xml.Linq;

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
        var count = employeeRepository.GetAllByDepartmentId(department.DeparmentId).Count;
        if (count >= department.EmployeeLimit)
        {
            throw new CapacityNotEnoughException(Helper.Errors["CapacityNotEnoughException"]);
        }
        Employee employee = new(name,surname,employeeCreateDto.salary,department.DeparmentId);
        employeeRepository.Add(employee);
    }
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetAll(int skip, int take)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetByDepartment(string departmentName)
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetEmployeeByDepartmentId(int id)
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

    public void Update(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, EmployeeCreateDto studentCreateDto)
    {
        throw new NotImplementedException();
    }
}
