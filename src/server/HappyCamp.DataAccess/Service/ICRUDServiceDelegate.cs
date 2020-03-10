using HappyCamp.Domain.DTOs;

namespace HappyCamp.DataAccess.Service
{
    internal interface ICRUDServiceDelegate<TDTO> where TDTO : DTO
    {
        TDTO Create(TDTO dto);
        bool Delete(long id);
        TDTO Get(long id);
        bool Update(TDTO dto);
    }
}