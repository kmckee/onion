using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using OnionArchitecture.Core.Models;
using OnionArchitecture.Infrastructure.Database.Dtos;
using OnionArchitecture.Infrastructure.Database.Interfaces;
using OnionArchitecture.Infrastructure.Database.Services;

namespace OnionArchitecture.UnitTests.Infrastructure.Services
{
    [TestFixture]
    public class ToDoWriterTests
    {
        private IToDoRepository _toDoRepository;
        private ToDoWriter _writer;

        [SetUp]
        public void SetUp()
        {
            _toDoRepository = Substitute.For<IToDoRepository>();
            _writer = new ToDoWriter(_toDoRepository);
        }

        [Test]
        public void Save_persists_the_id()
        {
            var expectedId = 3;
            var toDo = new ToDo() { Id = expectedId };

            _writer.Save(toDo);

            _toDoRepository.Received().Save(Arg.Is<ToDoDto>(t => t.Id == expectedId));
        }

        [Test]
        public void Save_persists_the_description()
        {
            var expectedDescription = "All The Things";
            var toDo = new ToDo() { Description = expectedDescription };
            
            _writer.Save(toDo);

            _toDoRepository.Received().Save(Arg.Is<ToDoDto>(t => t.Description == expectedDescription));
        }
    }
}
