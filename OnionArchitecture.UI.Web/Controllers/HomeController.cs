using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnionArchitecture.Core.Interfaces;
using OnionArchitecture.Core.Models;

namespace OnionArchitecture.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IToDoWriter _toDoWriter;

        public HomeController(IToDoWriter toDoWriter)
        {
            _toDoWriter = toDoWriter;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ToDo toDo)
        {
            _toDoWriter.Save(toDo);
            return RedirectToAction("Index");
        }
    }
}
