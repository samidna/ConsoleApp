using Global.Core.Interfaces;

namespace Global.Core.Entities;

public class Employee : IEntity
{
    private static int _id;
    public int EmployeeId { get; }
    public string EmployeeName { get; set; }
    public string EmployeeSurname { get; set; }
    public double Salary { get; set; }
    public int DepartmentId { get; set; }
    public Employee()
    {
        EmployeeId = _id;
        _id++;
    }
    public Employee(string name, string surname, double salary,int departmentId) : this()
    {
        EmployeeName = name;
        EmployeeSurname = surname;
        Salary = salary;
        DepartmentId = departmentId;
    }
    public string EmployeeInfo()
    {
        return $"Name : {EmployeeName}, Surname : {EmployeeSurname},Salary : {Salary}";
    }
}
