using System;
using System.Collections.Generic;
using Domain;
using Deposito_TG.Repositorio;
using Concessionaria.Repositorio;

namespace Repositorio 
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {
        private Contexto contexto;

        public void Excluir(int id)
        {
            using (contexto = new Contexto())
            {
                var del = contexto.ExecutaProcedure("TGDB_ProdutoExcluir");
                del.Parameters.AddWithValue("@idpro", id);
                del.ExecuteNonQuery();
                del.Dispose();
            }
        }

        public IEnumerable<Produto> Listar()
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_ProdutoListar");
                var produtos = new List<Produto>();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        produtos.Add(new Produto
                        (
                            reader.ReadAsInt("idpro"),
                            reader.ReadAsString("descricao"),
                            reader.ReadAsDecimal("preco"),
                            new Vendedor (reader.ReadAsInt("idvendedor"))                            
                        ));
                    }
                cmd.Dispose();
                return produtos;
            }
        }

        public void Salvar(Produto produto)
        {
            if (produto.IdPro > 0)
                Editar(produto);
            else Inserir(produto);
        }

        private void Inserir(Produto produto)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_ProdutoInserir");
                cmd.Parameters.AddWithValue("@idvendedor", produto.Vendedor.IdVen);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@preco", produto.Preco);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private void Editar(Produto produto)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_ProdutoEditar");
                cmd.Parameters.AddWithValue("@idpro", produto.IdPro);
                cmd.Parameters.AddWithValue("@idvendedor", produto.Vendedor.IdVen);
                cmd.Parameters.AddWithValue("@descricao", produto.Descricao);
                cmd.Parameters.AddWithValue("@preco", produto.Preco); cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public Produto Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
