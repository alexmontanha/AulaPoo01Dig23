using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo01Dig23
{
    public class ProfessorMensalista: Professor
    {
        public double ValorSalarioMensal { get; set; }

        public int RegistroProfessor { get; set; }

        public string RegistroProfessorFormatado
        {
            get
            {
                return $"{RegistroProfessor:000000}";
            }
        }

        public int RetornarRegistroProfessor(int i)
        {
            return RegistroProfessor;
        }

        public string RetornarRegistroProfessor()
        {
            return $"{RegistroProfessor:000000}";
        }

        public override double CalcularSalario()
        {
            return ValorSalarioMensal;
        }
    }
}
