using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Models;

namespace OnionArchitecture.Core.Services
{
    // This service is an example of a domain service with a dependency on an infrastructure service.
    public class ToDoCompleter : IToDoCompleter
    {
        private readonly IToDoWriter _toDoWriter;

        public ToDoCompleter(IToDoWriter toDoWriter)
        {
            _toDoWriter = toDoWriter;
        }

        public void Complete(ToDo toDo)
        {
            toDo.IsComplete = true;
            _toDoWriter.Save(toDo);
        }
    }
}
