using Global.Core.Interfaces;

namespace Global.DataAccess.Interfaces;

public interface IRepository<T> where T : IEntity
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T? Get(int id);
    T? GetByName(string name);
    List<T> GetAll();
    List<T> GetAllByName(string name);
}
