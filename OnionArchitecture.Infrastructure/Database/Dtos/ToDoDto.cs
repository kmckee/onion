using System;

namespace OnionArchitecture.Infrastructure.Database.Dtos
{
    // DTO's are coupled to the structure of the data in the database.
    // Reader & Writer services map these to the actual domain (eventually probably used AutoMapper or something).
    // DTOs live in a project that is not referenced by the UI of the application - Database abstractions do not leak into my domain & UI
    public class ToDoDto
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
    }
}
