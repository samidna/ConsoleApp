using Global.Core.Interfaces;

namespace Global.Core.Entities;

public class Department : IEntity
{
    private static int _id;
    public string DepartmentName { get; set; }
    public int EmployeeLimit;
    public int CompanyId { get; set; }
    public int DepartmentId { get; }
    public Department()
    {
        DepartmentId = _id;
        _id++;
    }
    public Department(string name, int employeelimit, int companyId) : this()
    {
        DepartmentName = name;
        EmployeeLimit = employeelimit;
        CompanyId = companyId;
    }
    public string DepartmentInfo()
    {
        return $"Id : {DepartmentId}, Name : {DepartmentName}";
    }
}
