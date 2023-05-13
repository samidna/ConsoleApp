using Global.Core.Interfaces;

namespace Global.Core.Entities;

public class Company : IEntity
{
    private static int _id;
    public string CompanyName { get; set; }
    public int CompanyId { get; }
    public Company()
    {
        CompanyId = _id;
        _id++;
    }
    public Company(string name) : this()
    {
        CompanyName = name;
    }

}
