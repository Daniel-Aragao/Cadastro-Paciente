using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class PacienteManager
    {


        public List<Paciente> Get( Paciente entity)
        {
            List<Paciente> ret = new List<Paciente>();


            //Add data access
            ret = CreateMockData();
            //Context _ctx = new Context();
            //IEnumerable<Paciente> pacientes = _ctx.Pacientes.ToArray();

            if (!string.IsNullOrEmpty(entity.Nome))
            {
                ret = ret.FindAll(p => p.Nome.ToLower().StartsWith(entity.Nome, StringComparison.CurrentCultureIgnoreCase));
            }




            return ret;
        }
 
        private List<Paciente> CreateMockData()
        {
            List<Paciente> ret = new List<Paciente>();

            ret.Add(new Paciente()
            {
                Altura = 1.72,
                Nome = "Carlos",
                Peso = 80,
                Sexo = 'M',
                TipoTratamento = 1,
                DataNascimento = new DateTime(1995, 11, 17),
                PacienteId = 0
            });
            ret.Add(new Paciente()
            {
                Altura = 1.60,
                Nome = "Renata",
                Peso = 50,
                Sexo = 'F',
                TipoTratamento = 2,
                DataNascimento = new DateTime(1998, 11, 08),
                PacienteId = 2
            });
            ret.Add(new Paciente()
            {
                Altura = 1.80,
                Nome = "Breno",
                Peso = 90,
                Sexo = 'M',
                TipoTratamento = 3,
                DataNascimento = new DateTime(1990, 11, 22),
                PacienteId = 1
            });

            return ret;

        }
    }
}
