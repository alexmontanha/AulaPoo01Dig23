using System;

namespace AulaPoo01Dig23
{
    public class Pessoa
    {

        private int calcularDigitoVerificador()
        {
            int multiplicador = 2;
            int digitoVerificador = (NumeroDocRegistro * multiplicador) + 11;
            return digitoVerificador;
        }

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int NumeroDocRegistro { get; set; }
        public int DigitoVerificador
        {
            get => calcularDigitoVerificador();
        }

        public int Idade
        {
            get
            {
                return DateTime.Now.Year - DataNascimento.Year;
            }
        }

        public override string ToString()
        {
            return $"Nome: {Nome} - Data de Nascimento: {DataNascimento} - Idade: {Idade} - Número de Registro: {NumeroDocRegistro} - {DigitoVerificador}";
        }
    }
}
