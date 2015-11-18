using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Maps
{
    public class PacienteMap : EntityTypeConfiguration<Paciente>
    {
        public PacienteMap()
        {
            ToTable("Paciente");

            Property(p => p.PacienteId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName("ID");

            Property(p => p.Nome)
                .IsRequired().HasColumnName("Nome");

            Property(p => p.Peso)
                .IsRequired()
                .HasColumnName("Peso");

            Property(p => p.TipoTratamento)
                .IsRequired()
                .HasColumnName("Tratamento");

            Property(p => p.DataNascimento)
                .IsRequired()
                .HasColumnName("DataNascimento");
        }
    }
}
