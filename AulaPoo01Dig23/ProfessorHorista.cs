using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo01Dig23
{
    public class ProfessorHorista: Professor
    {
        private int numeroHorasAula;

        public double ValorHoraAula { get; set; }

        public int NumeroHorasAula
        {
            get => numeroHorasAula;

            set
            {
                if (value < 0)
                {
                    throw new Exception("Número de horas de aula não pode ser negativo");
                }
                numeroHorasAula = value;
            }
        }

        public override double CalcularSalario()
        {
            return ValorHoraAula * NumeroHorasAula;
        }
    }
}
