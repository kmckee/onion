using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using OnionArchitecture.Core.Models;
using OnionArchitecture.Infrastructure.Database.Interfaces;
using OnionArchitecture.Infrastructure.Database.Models;
using OnionArchitecture.Infrastructure.Database.Services;

namespace OnionArchitecture.UnitTests.Infrastructure.Services
{
    [TestFixture]
    public class ToDoWriterTests
    {

        [Test]
        public void Save_persists_the_description()
        {
            var toDoRepository = Substitute.For<IToDoRepository>();
            var writer = new ToDoWriter(toDoRepository);

            var expectedDescription = "All The Things";
            var toDo = new ToDo() { Description = expectedDescription };
            
            writer.Save(toDo);

            toDoRepository.Received().Save(Arg.Is<ToDoDto>(t => t.Description == expectedDescription));
        }

        [Test]
        public void Save_persists_the_id()
        {
            var toDoRepository = Substitute.For<IToDoRepository>();
            var writer = new ToDoWriter(toDoRepository);

            var expectedId = 3;
            var toDo = new ToDo() { Id = expectedId };

            writer.Save(toDo);

            toDoRepository.Received().Save(Arg.Is<ToDoDto>(t => t.Id == expectedId));
        }
    }
}
