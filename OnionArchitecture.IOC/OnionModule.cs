using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Services;
using OnionArchitecture.Infrastructure;
using OnionArchitecture.Infrastructure.Database;
using OnionArchitecture.Infrastructure.Database.Interfaces;
using OnionArchitecture.Infrastructure.Database.Repositories;
using OnionArchitecture.Infrastructure.Database.Services;

namespace OnionArchitecture.IOC
{
    public class OnionModule : NinjectModule
    {
        // This assembly allows me to bind interfaces in the core assembly to implementation in the Infrastructure assembly
        // without having to add a reference to Infrastructure from UI.Web.  This keeps database objects out of the UI, and 
        // forces us to use abstractions defined in the Core assembly.
        public override void Load()
        {
            Bind<IToDoCompleter>().To<ToDoCompleter>();
            Bind<IToDoWriter>().To<ToDoWriter>();
            Bind<IToDoDtoRepository>().To<ToDoDtoRepository>();
            Bind<EfDbContext>().ToSelf();
        }
    }
}
