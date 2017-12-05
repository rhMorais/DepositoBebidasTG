using System;

namespace Domain
{
    public class ItemAlugavel
    {
        public Pedido Pedido { get; set; }
        public BemAlugavel BemAlugavel { get; set; }
        public int Qtde { get; set; }
        public decimal Total { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }

        public ItemAlugavel(BemAlugavel bemAlugavel, int qtde, DateTime inicio, DateTime fim, decimal total, Pedido pedido)
        {
            BemAlugavel = bemAlugavel;
            Qtde = qtde;
            Inicio = inicio;
            Fim = fim;
            Total = total;
            Pedido = pedido;
        }
    }
}
