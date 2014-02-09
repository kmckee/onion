using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture.Infrastructure.Database.Dtos;
using OnionArchitecture.Infrastructure.Database.Interfaces;

namespace OnionArchitecture.Infrastructure.Database.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        public void Save(ToDoDto toDo)
        {
            Debug.WriteLine(toDo.ToString());
        }
    }
}
