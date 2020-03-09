using System;
using System.Collections.Generic;

namespace HappyCamp.Domain.DTOs
{
    public class Person : DTO
    {
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public Lazy<IEnumerable<Role>> Roles { get; set; }
    }
}
