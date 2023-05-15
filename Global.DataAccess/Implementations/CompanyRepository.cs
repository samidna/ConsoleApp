using Global.Core.Entities;
using Global.DataAccess.Contexts;
using Global.DataAccess.Interfaces;

namespace Global.DataAccess.Implementations;

public class CompanyRepository : IRepository<Company>
{
    public void Add(Company entity)
    {
        DbContext.Companies.Add(entity);
    }

    public void Delete(Company entity)
    {
        DbContext.Companies.Remove(entity);
    }

    public void Update(Company entity)
    {
        Company company = DbContext.Companies.Find(c => c.CompanyId == entity.CompanyId);
        company.CompanyName = entity.CompanyName;
    }
    public Company? Get(int id)
    {
        return DbContext.Companies.Find(c => c.CompanyId == id);
    }
    public Company GetByName(string name)
    {
        return DbContext.Companies.Find(c => c.CompanyName == name);
    }
    public List<Company> GetAll()
    {
        return DbContext.Companies;
    }
    public List<Company> GetAllByName(string name)
    {
        return DbContext.Companies.FindAll(c => c.CompanyName.ToLower() == name);
    }
}
