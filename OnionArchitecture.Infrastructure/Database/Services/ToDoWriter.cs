using System;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Models;
using OnionArchitecture.Infrastructure.Database.Dtos;
using OnionArchitecture.Infrastructure.Database.Interfaces;

namespace OnionArchitecture.Infrastructure.Database.Services
{
    // Services that deal with DTOs directly need to live in the infrastructure assembly.
    // The interface, however, is defined in the Core assembly.
    public class ToDoWriter : IToDoWriter
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoWriter(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public void Save(ToDo todo)
        {
            var dto = MapToDto(todo);
            _toDoRepository.Save(dto);
        }

        private static ToDoDto MapToDto(ToDo todo)
        {
            return new ToDoDto
            {
                Id = todo.Id,
                Description = todo.Description
            };
        }
    }
}
