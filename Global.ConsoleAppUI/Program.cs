using Global.Business.DTOs.EmployeeDto;
using Global.Business.Services;
using Global.Core.Entities;
using Global.DataAccess.Contexts;
using Global.DataAccess.Implementations;

EmployeeService employeeService = new EmployeeService();
DepartmentService departmentService = new DepartmentService();
CompanyService companyService = new CompanyService();
EmployeeRepository employeeRepository = new EmployeeRepository();



//Console.WriteLine("First");
companyService.Create("Audi");
companyService.Create("BMW");
companyService.Create("Porshce");


departmentService.Create("Maliyye","Audi",15);
departmentService.Create("Maliyye1", "BMW", 11);
departmentService.Create("Maliyye2", "Porshce", 12);
departmentService.Create("Maliyye3", "Porshce", 16);
departmentService.Create("Maliye", "BMW", 15);
departmentService.Create("Maliye1", "Audi", 15);


//Console.WriteLine("Second");
//Console.WriteLine("get all companies");
//foreach (var companies in companyService.GetAll())
//{
//    Console.WriteLine(companies.CompanyName);
//}

//Console.WriteLine("Departments:");
//Console.WriteLine("Departments1:");
//foreach (var department in departmentService.GetAll())
//{
//    Console.WriteLine(department.DepartmentName);
//}

//Console.WriteLine("Create student:");
EmployeeCreateDto s1 = new("Adil", "Tehranli", 15000,"Maliyye");
EmployeeCreateDto s2 = new("Kenan", "Qehremanov", 15000, "Maliyye1");
EmployeeCreateDto s3 = new("Samid", "Saitli", 15000, "Maliyye");
EmployeeCreateDto s4 = new("Samid", "Saitli", 15000, "Maliyye2");
EmployeeCreateDto s5 = new("Samid", "Saitlii", 15000, "Maliyye");
employeeService.Create(s1);
employeeService.Create(s2);
employeeService.Create(s3);
employeeService.Create(s4);
employeeService.Create(s5);
Console.WriteLine("ss");
//departmentService.Delete("Maliyye1");
//var department= departmentService.GetById(0);
//Console.WriteLine(department.DepartmentName);

//departmentService.Delete("Maliyye");
//employeeService.Delete(10);
//foreach (var employee in employeeService.GetAll(0, 5))
//{
//    Console.WriteLine(employee.EmployeeId);
//}
//var stu = employeeService.GetEmployeeById(2);
//Console.WriteLine(stu.EmployeeInfo());
//foreach (var employee in employeeService.GetEmployeeByName("Samid"))
//{
//    Console.WriteLine(employee.EmployeeInfo());
//}
//foreach (var employee in employeeService.GetByDepartment("Maliyye"))
//{
//    Console.WriteLine(employee.EmployeeInfo());
//}
//var emp=companyService.GetById(1);
//Console.WriteLine(emp);
//var dep = departmentService.GetById(1);
//Console.WriteLine(dep);
//Console.WriteLine("a");
//employeeService.GetByDepartment("Maliyye");
//employeeService.GetEmployeeByName("Samid");
//var dep=departmentService.GetByName("Maliyye");
//Console.WriteLine(dep);
//Console.WriteLine(departmentService.GetById(6).DepartmentName);
//employeeService.UpdateEmployeeSalary(5, 30000);
//foreach (var emp in DbContext.Employees)
//{
//    Console.WriteLine(emp.Salary);
//}
//employeeService.EmployeeTransfer(1, "Maliyye");
//foreach (var emp in DbContext.Employees)
//{
//    Console.WriteLine(emp.DepartmentName);
//}
//Console.WriteLine(employeeRepository.Get(1).DepartmentName);

//departmentService.UpdateDepartment("Maliyye","Maliyye7", 35);
//foreach (var dep in DbContext.Departments)
//{
//    Console.WriteLine(dep.DepartmentName);
//}















