using Global.Core.Entities;

namespace Global.DataAccess.Contexts;

public static class DbContext
{
    public static List<Employee> Employees { get; set; } = new();
    public static List<Department> Departments { get; set; } = new();
    public static List<Company> Companies { get; set; } = new();
}
