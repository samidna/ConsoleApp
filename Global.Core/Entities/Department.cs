using Global.Core.Interfaces;

namespace Global.Core.Entities;

public class Department : IEntity
{
    private static int _id;
    public string DepartmentName { get; set; }
    public int EmployeeLimit;
    public int CompanyId { get; set; }
    public int DeparmentId { get; }
    public Department()
    {
        DeparmentId = _id;
        _id++;
    }
    public Department(string name, int employeelimit,int companyId) : this()
    {
        DepartmentName = name;
        EmployeeLimit = employeelimit;
        CompanyId = companyId;
    }
}
