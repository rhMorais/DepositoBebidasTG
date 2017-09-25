using System.Collections.Generic;

namespace Domain
{
    public class Pedido
    {
        public Pedido(int idPed, string observacao, decimal desconto, decimal vlTotal, Atendente atendente, Cliente cliente)
        {
            IdPed = idPed;
            Observacao = observacao;
            Desconto = desconto;            
            Atendente = atendente;
            Cliente = cliente;         
            VlTotal = vlTotal;
        }

        public Pedido(int idPed)
        {
            IdPed = idPed;
        }

        public int IdPed { get; set; }
        public string Observacao { get; set; }
        public decimal Desconto { get; set; }
        public decimal VlTotal { get; set; }
        public Atendente Atendente { get; set; }
        public Cliente Cliente { get; set; }
        public IEnumerable<Itens> Itens { get; set; }
        public IEnumerable<ItemAlugavel> ItensAlugaveis { get; set; }
    }
}
