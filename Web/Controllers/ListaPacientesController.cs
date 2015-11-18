using Core;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ListaPacientesController : Controller
    {
        Context _ctx;
        IEnumerable<Paciente> pacientes;

        public ListaPacientesController()
        {
            _ctx = new Context();
            pacientes = new List<Paciente>(); 
        }

        [HttpGet]
        public ActionResult Index()
        {
            pacientes = _ctx.Pacientes.ToList();
            return View(pacientes);
        }

    }
}