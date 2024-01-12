using CRM.Domain;

namespace CRM.Shared.Interfaces
{
    public interface IRepository<T>
    {

        List<T> GetAll();
        T Add(T entity);
        T? GetById(int id);
        bool Remove(T customer);
        T Update(T customer);
    }
}