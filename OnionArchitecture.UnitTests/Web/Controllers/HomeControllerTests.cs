using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NSubstitute;
using NUnit.Framework;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Models;
using OnionArchitecture.UI.Web.Controllers;
using FluentAssertions;

namespace OnionArchitecture.UnitTests.Web.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Index_returns_a_view()
        {
            var toDoWriter = NSubstitute.Substitute.For<IToDoWriter>();
            var controller = new HomeController(toDoWriter);

            var result = controller.Index();

            result.Should().BeOfType<ViewResult>();
        }

        [Test]
        public void Create_get_returns_a_view()
        {
            var toDoWriter = NSubstitute.Substitute.For<IToDoWriter>();
            var controller = new HomeController(toDoWriter);

            var result = controller.Create();

            result.Should().BeOfType<ViewResult>();
        }

        [Test]
        public void Create_post_saves_a_new_to_do()
        {
            var toDoWriter = NSubstitute.Substitute.For<IToDoWriter>();
            var controller = new HomeController(toDoWriter);
            var newToDo = new ToDo();

            controller.Create(newToDo);

            toDoWriter.Received().Save(newToDo);
        }
    }
}
