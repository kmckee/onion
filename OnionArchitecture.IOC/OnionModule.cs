using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Infrastructure;

namespace OnionArchitecture.IOC
{
    public class OnionModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IToDoWriter>().To<ToDoRepository>();
        }
    }
}
