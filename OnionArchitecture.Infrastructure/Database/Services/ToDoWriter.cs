using System;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Models;
using OnionArchitecture.Infrastructure.Database.Interfaces;
using OnionArchitecture.Infrastructure.Database.Models;

namespace OnionArchitecture.Infrastructure.Database.Services
{
    public class ToDoWriter : IToDoWriter
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoWriter(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public void Save(ToDo todo)
        {
            var dto = new ToDoDto
            {
                Id = todo.Id,
                Description = todo.Description
            };
            _toDoRepository.Save(dto);
        }
    }
}
