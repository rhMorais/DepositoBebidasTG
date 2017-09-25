namespace Domain
{
    public class Atendente
    {
        public Atendente(int idAten, string nome)
        {
            IdAten = idAten;
            Nome = nome;
        }

        public Atendente( string nome)
        {
            Nome = nome;
        }

        public Atendente()
        {
        }
        public int IdAten { get; set; }
        public string Nome { get; set; }
    }
}
