using System;

namespace HappyCamp.DataAccess.Entities
{
    class PersonEntity : Entity
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
    }
}
