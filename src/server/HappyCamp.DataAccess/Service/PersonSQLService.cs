using HappyCamp.DataAccess.Converters;
using HappyCamp.DataAccess.Entities;
using HappyCamp.Domain.DTOs;

namespace HappyCamp.DataAccess.Service
{
    class PersonSQLService : AbstractSQLService<Person>
    {
        PersonSQLService() : base(new PersonToPersonEntityConverter(), new PersonEntityToPersonConverter(), new CRUDServiceDelegate<PersonEntity>()) { }
    }
}
