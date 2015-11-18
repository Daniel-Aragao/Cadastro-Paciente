using Core;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            
            PacienteViewModel pvm = new PacienteViewModel();

            pvm.HandleRequest();

            return View(pvm);
        }
        [HttpPost]
        public ActionResult Index(PacienteViewModel pvm)
        {
            pvm.HandleRequest();

            ModelState.Clear();

            return View(pvm);
        }

    }
}