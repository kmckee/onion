using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Infrastructure;
using OnionArchitecture.Infrastructure.Database;
using OnionArchitecture.Infrastructure.Database.Services;

namespace OnionArchitecture.IOC
{
    public class OnionModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IToDoWriter>().To<ToDoWriter>();
        }
    }
}
