using HappyCamp.DataAccess.Converters;
using HappyCamp.DataAccess.Entities;
using HappyCamp.Domain.DTOs;

namespace HappyCamp.DataAccess.Service
{
    internal class PersonSQLService : AbstractSQLService<Person>
    {
        public PersonSQLService() : base(
            new PersonToPersonEntityConverter(), 
            new PersonEntityToPersonConverter(), 
            new CRUDServiceDelegate<PersonEntity>()) { }
    }
}
