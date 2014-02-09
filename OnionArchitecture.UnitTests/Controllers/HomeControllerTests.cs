﻿using System;
using System.Web.Mvc;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Models;
using OnionArchitecture.UI.Web.Controllers;

namespace OnionArchitecture.UnitTests.Controllers
{
    [TestFixture]
    public class HomeControllerTests
    {
        private IToDoWriter _toDoWriter;
        private HomeController _controller;

        [SetUp]
        public void SetUp()
        {
            _toDoWriter = Substitute.For<IToDoWriter>();
            _controller = new HomeController(_toDoWriter);
        }

        [Test]
        public void Index_returns_a_view()
        {
            var result = _controller.Index();

            result.Should().BeOfType<ViewResult>();
        }

        [Test]
        public void Create_get_returns_a_view()
        {
            var result = _controller.Create();

            result.Should().BeOfType<ViewResult>();
        }

        [Test]
        public void Create_post_saves_a_new_to_do()
        {
            var newToDo = new ToDo();

            _controller.Create(newToDo);

            _toDoWriter.Received().Save(newToDo);
        }

        [Test]
        public void Create_post_redirects_to_index()
        {
            var result = _controller.Create(new ToDo() {Created = DateTime.Now, Description = "Foo"});
            result.Should().BeOfType<RedirectToRouteResult>();
            (result as RedirectToRouteResult).RouteValues.Should().Contain("Action", "Index");
        }
    }
}