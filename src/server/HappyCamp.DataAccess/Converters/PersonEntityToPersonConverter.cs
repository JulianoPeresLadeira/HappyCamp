using HappyCamp.DataAccess.Entities;
using HappyCamp.Domain.DTOs;

namespace HappyCamp.DataAccess.Converters
{
    class PersonEntityToPersonConverter : BaseConverter
    {
        public Person Convert(PersonEntity from)
        {
            return base.Convert<PersonEntity, Person>(from);
        }
    }
}
