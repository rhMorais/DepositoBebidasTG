namespace Domain
{
    public class Itens
    {
        public Itens(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Total = produto.Preco * quantidade;
        }

        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; }
    }
}
