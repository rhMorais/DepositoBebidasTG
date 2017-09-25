using System;
using System.Collections.Generic;
using Domain;
using Deposito_TG.Repositorio;
using Concessionaria.Repositorio;

namespace Repositorio
{
    public class PedidoRepositorio : IRepositorio<Pedido>
    {
        private Contexto contexto;

        public void Excluir(int id)
        {
            using (contexto = new Contexto())
            {
                var del = contexto.ExecutaProcedure("TGDB_PedidoExcluir");
                del.Parameters.AddWithValue("@idped", id);
                del.ExecuteNonQuery();
                del.Dispose();
            }
        }

        public IEnumerable<Pedido> Listar()
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_PedidoListar");
                var pedidoes = new List<Pedido>();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        pedidoes.Add(new Pedido
                        (
                            reader.ReadAsInt("idped"),
                            reader.ReadAsString("idobs"),
                            reader.ReadAsDecimal("desconto"),
                            reader.ReadAsDecimal("vltotal"),
                            new Atendente ( reader.ReadAsString("nome")),
                            new Cliente (reader.ReadAsString("nome"))                            
                        ));
                    }
                cmd.Dispose();
                return pedidoes;
            }
        }

        public void Salvar(Pedido pedido)
        {
            if (pedido.IdPed > 0)
                Editar(pedido);
            else Inserir(pedido);
        }

        private void Inserir(Pedido pedido)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_PedidoInserir");
                cmd.Parameters.AddWithValue("@idobs", pedido.Observacao);
                cmd.Parameters.AddWithValue("@desconto", pedido.Desconto);
                cmd.Parameters.AddWithValue("@vltotal", pedido.VlTotal);
                cmd.Parameters.AddWithValue("@idaten", pedido.Atendente.IdAten);
                cmd.Parameters.AddWithValue("@idcli", pedido.Cliente.IdCli);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private void Editar(Pedido pedido)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_PedidoEditar");
                cmd.Parameters.AddWithValue("@idped", pedido.IdPed);
                cmd.Parameters.AddWithValue("@idobs", pedido.Observacao);
                cmd.Parameters.AddWithValue("@desconto", pedido.Desconto);
                cmd.Parameters.AddWithValue("@vltotal", pedido.VlTotal);
                cmd.Parameters.AddWithValue("@idaten", pedido.Atendente.IdAten);
                cmd.Parameters.AddWithValue("@idcli", pedido.Cliente.IdCli);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public Pedido Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
