using Core;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class PacienteViewModel
    {
        public string EventCommand { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public Paciente SearchEntity { get; set; }

        public PacienteViewModel()
        {
            Pacientes = new List<Paciente>();
            EventCommand = "List";
            SearchEntity = new Paciente();
        }

        private void ResetSearch()
        {
            SearchEntity = new Paciente();
        }

        private void Get()
        {
            PacienteManager manager = new PacienteManager();


            Pacientes =  manager.Get(SearchEntity);
        }

        public void HandleRequest()
        {
            switch(EventCommand.ToLower())
            {
                case "list":
                case "search":
                    Get();
                    break;
                case "limpar":
                    ResetSearch();
                    break;
                case "imprimir":
                    break;
                case "adicionar":
                    break;
            }
        }


    }
}