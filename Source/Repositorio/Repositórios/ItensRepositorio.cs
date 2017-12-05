using System;
using System.Collections.Generic;
using Domain;
using Deposito_TG.Repositorio;
using Concessionaria.Repositorio;

namespace Repositorio
{
    public class ItensRepositorio
    {
        private Contexto contexto;

        public void Excluir(int idped, int idpro)
        {
            using (contexto = new Contexto())
            {
                var del = contexto.ExecutaProcedure("TGDB_Pedido_ProdutoExcluir");
                del.Parameters.AddWithValue("@idped", idped);
                del.Parameters.AddWithValue("@idpro", idpro);
                del.ExecuteNonQuery();
                del.Dispose();
            }
        }

        public IEnumerable<Itens> listar()
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_Pedido_ProdutoListar");
                var Itenss = new List<Itens>();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        Itenss.Add(new Itens
                        (                            
                            new Produto(reader.ReadAsString("descricao")),                                                    
                            reader.ReadAsInt("qtde"),
                            reader.ReadAsDecimal("total"),
                            new Pedido(reader.ReadAsInt("idped"))
                        ));
                    }
                cmd.Dispose();
                return Itenss;
            }
        }    

        private void Inserir(Itens itens)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_Pedido_ProdutoInserir");
                cmd.Parameters.AddWithValue("@idped", itens.Pedido.IdPed);
                cmd.Parameters.AddWithValue("@idpro", itens.Produto.IdPro);
                cmd.Parameters.AddWithValue("@qtde", itens.Quantidade);
                cmd.Parameters.AddWithValue("@total", itens.Total);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private void Editar(Itens itens)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_Pedido_ProdutoEditar");
                cmd.Parameters.AddWithValue("@idped", itens.Pedido.IdPed);
                cmd.Parameters.AddWithValue("@idpro", itens.Produto.IdPro);
                cmd.Parameters.AddWithValue("@qtde", itens.Quantidade);
                cmd.Parameters.AddWithValue("@total", itens.Total);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }
    }
}
