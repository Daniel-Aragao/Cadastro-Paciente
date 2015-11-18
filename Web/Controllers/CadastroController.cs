using Core;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class CadastroController : Controller
    {

        Context _ctx;

        public CadastroController()
        {
            _ctx = new Context();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Paciente paciente)
        {
            /*List<KeyValuePair<string, string>> errors = new List<KeyValuePair<string, string>>();
            errors.Add(new KeyValuePair<string, string>("Nome", "Esse paciente já foi cadastrado"));

            ModelState.AddModelError(errors[0].Key, errors[0].Value);
            */
            if (ModelState.IsValid)
            {
                try
                {
                    _ctx.Pacientes.Add(paciente);
                    _ctx.SaveChanges();

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                return RedirectToAction("Index", "ListaPacientes");
            }
            return View();
        }
    }
}