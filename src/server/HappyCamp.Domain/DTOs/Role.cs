using System;
using System.Collections.Generic;

namespace HappyCamp.Domain.DTOs
{
    public class Role : DTO
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public Lazy<IEnumerable<Person>> People { get; set; }
    }
}
