using System;

namespace OnionArchitecture.Core.Models
{
    // This domain object is not directly coupled to my database design.
    // The domain objects are translated to one or more DTO objects.
    // Changing the name of a column in the database will only affect mappings, it won't affect services or UI.
    public class ToDo
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public bool IsComplete { get; set; }
    }
}
