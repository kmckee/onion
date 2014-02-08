using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnionArchitecture.Core.Interfaces;

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

        public ActionResult Add(string description)
        {
            throw new NotImplementedException();
        }
    }
}
