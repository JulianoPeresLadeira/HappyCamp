using HappyCamp.Domain.DTOs;
using System.Collections.Generic;

namespace HappyCamp.Domain.Facades
{
    public interface IPersonFacade : IFacade<Person>
    {
        IEnumerable<Person> GetByNationality(string nationality);
        IEnumerable<Person> GetByAge(ushort age);
        Person GetByEmail(string email);
    }
}
