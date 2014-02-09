using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Models;
using OnionArchitecture.Core.Services;

namespace OnionArchitecture.UnitTests.Services
{
    [TestFixture]
    public class ToDoCompleterServiceTests
    {
        private IToDoWriter _toDoWriter;
        private ToDoCompleter _toDoCompleter;

        [SetUp]
        public void SetUp()
        {
            _toDoWriter = Substitute.For<IToDoWriter>();
            _toDoCompleter = new ToDoCompleter(_toDoWriter);
        }

        [Test]
        public void Complete_marks_todo_completed()
        {
            _toDoWriter = NSubstitute.Substitute.For<IToDoWriter>();
            var toDo = new ToDo() {IsComplete = false};

            _toDoCompleter.Complete(toDo);

            toDo.IsComplete.Should().Be(true);
        }

        [Test]
        public void Complete_saves_the_completed_todo()
        {
            var toDo = new ToDo();

            _toDoCompleter.Complete(toDo);

            _toDoWriter.Received().Save(toDo);
        }
    }
}
