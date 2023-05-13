using Global.Core.Entities;

namespace Global.Business.Interfaces;

public interface ICompanyService
{
    void Create(string name);
    void Delete(string name);
    Company GetById(int id);
    List<Company> GetAll();
}
