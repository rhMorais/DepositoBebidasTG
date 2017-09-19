using System;

namespace Domain
{
    public class ItemAlugavel
    {
        public ItemAlugavel(BemAlugavel bemAlugavel, int qtde, DateTime inicio, DateTime fim)
        {
            BemAlugavel = bemAlugavel;
            Qtde = qtde;
            Inicio = inicio;
            Fim = fim;
            Total = BemAlugavel.VlAluguel * Qtde;
        }

        public BemAlugavel BemAlugavel{ get; set; }
        public int Qtde { get; set; }
        public decimal Total { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }

    }
}
