using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture.Infrastructure.Database.Dtos;

namespace OnionArchitecture.Infrastructure.Database.Interfaces
{
    public interface IToDoDtoRepository
    {
        void Save(ToDoDto toDo);
    }
}
