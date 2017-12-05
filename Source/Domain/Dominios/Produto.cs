namespace Domain
{
    public class Produto
    {
        public int IdPro { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public Vendedor Vendedor { get; set; }

        public Produto(int idPro, string descricao, decimal preco, Vendedor vendedor)
        {
            IdPro = idPro;
            Descricao = descricao;
            Preco = preco;
            Vendedor = vendedor;
        }
        public Produto(string descricao, decimal preco, Vendedor vendedor)
        {
            Descricao = descricao;
            Preco = preco;
            Vendedor = vendedor;
        }
        public Produto(string descricao) { Descricao = descricao; }
        public Produto() { }
    }
}
