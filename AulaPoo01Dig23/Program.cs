using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPoo01Dig23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esta é a tela da minha aplicação");

            Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "João";
            pessoa1.DataNascimento = new DateTime(1980, 1, 1);
            pessoa1.NumeroDocRegistro = 123456;

            Pessoa pessoa2 = new Pessoa();
            pessoa2.Nome = "Maria";
            pessoa2.DataNascimento = new DateTime(1985, 1, 1);
            pessoa2.NumeroDocRegistro = 654321;

            ProfessorHorista professor1 = new ProfessorHorista();
            professor1.Nome = "José";
            professor1.DataNascimento = new DateTime(1970, 1, 1);
            professor1.NumeroDocRegistro = 123456;
            professor1.Titulo = Titulacao.Mestrado;
            
            Console.WriteLine(pessoa1.ToString());
            Console.WriteLine(pessoa2.ToString());
            Console.WriteLine(professor1.ToString());

            Console.ReadKey();
        }
    }
}
