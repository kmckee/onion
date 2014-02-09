using System;

namespace OnionArchitecture.Infrastructure.Database.Dtos
{
    public class ToDoDto
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
    }
}
