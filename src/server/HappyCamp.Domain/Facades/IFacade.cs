using HappyCamp.Domain.DTOs;
using HappyCamp.Domain.Service;

namespace HappyCamp.Domain.Facades
{
    public interface IFacade<T> : IService<T>
        where T : DTO
    {
    }
}
