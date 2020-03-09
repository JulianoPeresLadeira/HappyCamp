using HappyCamp.DataAccess.Entities;
using HappyCamp.Domain.DTOs;

namespace HappyCamp.DataAccess.Converters
{
    class PersonEntityToPersonConverter : BaseConverter<PersonEntity, Person>
    {
        protected override void DoConvert(PersonEntity from, Person to)
        {
        }
    }
}
