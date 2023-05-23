namespace AulaPoo01Dig23
{
    public enum Titulacao
    {
        Graduacao,
        Especializacao,
        Mestrado,
        Doutorado
    }

    public abstract class Professor: Pessoa
    {
        public Titulacao Titulo { get; set; }

        public virtual double CalcularSalario()
        {
            throw new System.NotImplementedException();
        }
    }
}
