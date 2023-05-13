using Global.Business.Services;

EmployeeService employeeService = new EmployeeService();    
DepartmentService departmentService = new DepartmentService();  
CompanyService companyService = new CompanyService();
//Console.WriteLine("First");
companyService.Create("Audi");
companyService.Create("BMW");
//Console.WriteLine("Second");
Console.WriteLine("get all companies");
foreach (var companies in companyService.GetAll())
{
    Console.WriteLine(companies.CompanyName);
}

Console.WriteLine("Departments:");
departmentService.Create("Maliye", "BMW", 15);
Console.WriteLine("Departments1:");
departmentService.Create("Maliye", "Audi", 15);