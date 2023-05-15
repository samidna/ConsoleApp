using Global.Business.Exceptions;
using Global.Business.Helpers;
using Global.Business.Interfaces;
using Global.Core.Entities;
using Global.DataAccess.Contexts;
using Global.DataAccess.Implementations;

namespace Global.Business.Services;

public class CompanyService : ICompanyService
{
    public DepartmentRepository departmentRepository { get; }
    public CompanyRepository companyRepository { get; }
    public CompanyService()
    {
        companyRepository = new CompanyRepository();
    }
    public void Create(string companyName)
    {
        var exist = companyRepository.GetByName(companyName);
        if (exist != null)
        {
            throw new AlreadyExistException(Helper.Errors["AlreadyExistException"]);
        }
        string name = companyName.Trim();
        if (name.Length < 2)
        {
            throw new SizeException(Helper.Errors["SizeException"]);
        }
        Company company = new Company(companyName);
        companyRepository.Add(company);
    }
    public void Delete(string name)
    {
        var company = companyRepository.GetByName(name);
        if (company == null)
        {
            throw new NotFoundException("This company doesn't exist");
        }
        companyRepository.Delete(company);
    }
    public List<Company> GetAll()
    {
        return companyRepository.GetAll();
    }
    public Company GetById(int id)
    {
        var count = companyRepository.GetAll().;
        if (count < id)
        {
            throw new NotFoundException("This Id doesn't exist");
        }
        return DbContext.Companies.Find(c => c.CompanyId == id);
    }
}
