namespace Domain
{
    public class Itens
    {
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Total { get; }

        public Itens(Produto produto, int quantidade, decimal total, Pedido pedido)
        {
            Pedido = pedido;
            Produto = produto;
            Quantidade = quantidade;
            Total = total;
        }
    }
}
