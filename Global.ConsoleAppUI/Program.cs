using Global.Business.DTOs.EmployeeDto;
using Global.Business.Services;
using Global.DataAccess.Implementations;

EmployeeService employeeService = new EmployeeService();
DepartmentService departmentService = new DepartmentService();
CompanyService companyService = new CompanyService();
//Employee employee = new("Samid", "Aghayev", 15000, "Audi");
EmployeeRepository employeeRepository = new EmployeeRepository();



//Console.WriteLine("First");
companyService.Create("Audi");
companyService.Create("BMW");
departmentService.Create("Maliyye","Audi",15);
departmentService.Create("Maliyye1", "BMW", 11);


//Console.WriteLine("Second");
//Console.WriteLine("get all companies");
//foreach (var companies in companyService.GetAll())
//{
//    Console.WriteLine(companies.CompanyName);
//}

//Console.WriteLine("Departments:");
//departmentService.Create("Maliye", "BMW", 15);
//Console.WriteLine("Departments1:");
//departmentService.Create("Maliye1", "Audi", 15);
//foreach (var department in departmentService.GetAll())
//{
//    Console.WriteLine(department.DepartmentName);
//}

Console.WriteLine("Create student:");
EmployeeCreateDto s1 = new("Adil", "Tehranli", 15000,"Maliyye");
EmployeeCreateDto s2 = new("Kenan", "Qehremanov", 15000, "Maliyye1");
EmployeeCreateDto s3 = new("Samid", "Saitli", 15000, "Maliyye");
EmployeeCreateDto s4 = new("Samid", "Saitli", 15000, "Maliyye");
EmployeeCreateDto s5 = new("Samid", "Saitlii", 15000, "Maliyye");
employeeService.Create(s1);
employeeService.Create(s2);
employeeService.Create(s3);
employeeService.Create(s4);
employeeService.Create(s5);
foreach (var employee in employeeService.GetAll(2,5))
{
    Console.WriteLine(employee.EmployeeInfo());
}















