using HappyCamp.Domain.DTOs;

namespace HappyCamp.Domain.Service
{
    public interface IService<T>
        where T : DTO
    {
        T Get(long id);
        T Create(T obj);
        bool Update(T obj);
        bool Delete(long id);

    }
}
