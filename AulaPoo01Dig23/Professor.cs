namespace AulaPoo01Dig23
{
    public enum Titulacao
    {
        Graduacao,
        Especializacao,
        Mestrado,
        Doutorado
    }

    public class Professor: Pessoa
    {
        public Titulacao Titulo { get; set; }
    }
}
