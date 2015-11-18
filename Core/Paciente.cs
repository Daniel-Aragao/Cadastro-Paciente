using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Core
{
    public class Paciente
    {
        public int PacienteId { get; set; }
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int TipoTratamento { get; set; }
        public char Sexo { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
    }
}
