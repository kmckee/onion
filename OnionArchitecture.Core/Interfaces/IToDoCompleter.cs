using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnionArchitecture.Core.Models;

namespace OnionArchitecture.Core.Interfaces
{
    public interface IToDoCompleter
    {
        void Complete(ToDo toDo);
    }
}
