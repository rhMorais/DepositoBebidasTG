namespace Domain
{
    public class Vendedor
    {
        public int IdVen { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Empresa { get; set; }

        public Vendedor(int idVen, string nome, string telefone, string celular, string empresa)
        {
            IdVen = idVen;
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Empresa = empresa;
        }
        public Vendedor(string nome, string telefone, string celular, string empresa)
        {
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Empresa = empresa;
        }
        public Vendedor(string nome) { Nome = nome; }
        public Vendedor(int idVen) { IdVen = idVen; }
        public Vendedor() { }
    }
}
