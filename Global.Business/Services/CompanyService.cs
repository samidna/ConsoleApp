using Global.Business.Exceptions;
using Global.Business.Helpers;
using Global.Business.Interfaces;
using Global.Core.Entities;
using Global.DataAccess.Implementations;

namespace Global.Business.Services;

public class CompanyService : ICompanyService
{
    public CompanyRepository companyRepository { get; }
    public CompanyService()
    {
        companyRepository = new CompanyRepository();
    }
    public void Create(string companyName)
    {
        var exist = companyRepository.GetByName(companyName);
        if(exist != null)
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
        throw new NotImplementedException();
    }

    public List<Company> GetAll()
    {
        return companyRepository.GetAll();
    }

    public Company GetById(int id)
    {
        throw new NotImplementedException();
    }
}
