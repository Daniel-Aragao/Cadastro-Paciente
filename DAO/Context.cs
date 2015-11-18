using Core;
using DAO.Maps;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Context : DbContext
    {

        public DbSet<Paciente> Pacientes { get; set; }

        public Context() : base("CadastroPacienteDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new PacienteMap());
        }

    }
}
