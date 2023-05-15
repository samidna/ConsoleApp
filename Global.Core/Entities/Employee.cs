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
    public string DepartmentName { get; set; }
    public string CompanyName { get; }
    public Employee()
    {
        EmployeeId = _id;
        _id++;
    }
    public Employee(string name, string surname, double salary, string departmentName) : this()
    {
        EmployeeName = name;
        EmployeeSurname = surname;
        Salary = salary;
        DepartmentName = departmentName;
    }
    public string EmployeeInfo()
    {
        return $"Name : {EmployeeName}, Surname : {EmployeeSurname}, Salary : {Salary}";
    }
}
