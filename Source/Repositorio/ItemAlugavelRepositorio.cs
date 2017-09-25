using System;
using System.Collections.Generic;
using Domain;
using Deposito_TG.Repositorio;
using Concessionaria.Repositorio;

namespace Repositorio
{
    public class ItemAlugavelRepositorio 
    {
        private Contexto contexto;

        public void Excluir(int idped, int idbem)
        {
            using (contexto = new Contexto())
            {
                var del = contexto.ExecutaProcedure("TGDB_Aluguel_BemExcluir");
                del.Parameters.AddWithValue("@idped", idped);
                del.Parameters.AddWithValue("@idbem", idbem);
                del.ExecuteNonQuery();
                del.Dispose();
            }
        }

        public IEnumerable<ItemAlugavel> listar()
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_Aluguel_BemListar");
                var ItemAlugaveis = new List<ItemAlugavel>();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        ItemAlugaveis.Add(new ItemAlugavel
                        (
                            new BemAlugavel(reader.ReadAsString("descricao")),
                            reader.ReadAsInt("qtde"),
                            reader.ReadAsDateTime("inicio"),
                            reader.ReadAsDateTime("fim"),
                            reader.ReadAsDecimal("total"),
                            new Pedido(reader.ReadAsInt("idped"))
                        ));
                    }
                cmd.Dispose();
                return ItemAlugaveis;
            }
        }

        private void Inserir(ItemAlugavel itens)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_Aluguel_BemInserir");
                cmd.Parameters.AddWithValue("@idped", itens.Pedido.IdPed);
                cmd.Parameters.AddWithValue("@idbem", itens.BemAlugavel.IdBem);
                cmd.Parameters.AddWithValue("@qtde", itens.Qtde);
                cmd.Parameters.AddWithValue("@total", itens.Total);
                cmd.Parameters.AddWithValue("@inicio", itens.Inicio);
                cmd.Parameters.AddWithValue("@fim", itens.Fim);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private void Editar(ItemAlugavel itens)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_Aluguel_BemEditar");
                cmd.Parameters.AddWithValue("@idped", itens.Pedido.IdPed);
                cmd.Parameters.AddWithValue("@idbem", itens.BemAlugavel.IdBem);
                cmd.Parameters.AddWithValue("@qtde", itens.Qtde);
                cmd.Parameters.AddWithValue("@total", itens.Total);
                cmd.Parameters.AddWithValue("@inicio", itens.Inicio);
                cmd.Parameters.AddWithValue("@fim", itens.Fim);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }
    }
}
