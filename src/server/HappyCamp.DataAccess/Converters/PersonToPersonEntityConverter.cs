using HappyCamp.DataAccess.Entities;
using HappyCamp.Domain.DTOs;

namespace HappyCamp.DataAccess.Converters
{
    class PersonToPersonEntityConverter : BaseConverter
    {
        public PersonEntity Convert(Person from)
        {
            return base.Convert<Person, PersonEntity>(from);
        }
    }
}
