namespace Domain
{
    public class Vendedor
    {
        public Vendedor(int idVen, string nome, string telefone, string celular, string empresa)
        {
            IdVen = idVen;
            Nome = nome;
            Telefone = telefone;
            Celular = celular;
            Empresa = empresa;        
        }

        public Vendedor(int idVen)
        {
            IdVen = idVen;
        }

        public int IdVen { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Empresa { get; set; }
    }
}
