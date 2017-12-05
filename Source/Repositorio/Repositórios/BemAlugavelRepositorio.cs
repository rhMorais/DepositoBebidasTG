using Concessionaria.Repositorio;
using Deposito_TG.Repositorio;
using Domain;
using System;
using System.Collections.Generic;

namespace Repositorio
{
    public class BemAlugavelRepositorio : IRepositorio<BemAlugavel>
    {
        private Contexto contexto;

        public void Excluir(int id)
        {
            using (contexto = new Contexto())
            {
                var del = contexto.ExecutaProcedure("TGDB_BemalugavelExcluir");
                del.Parameters.AddWithValue("@idbem", id);
                del.ExecuteNonQuery();
                del.Dispose();
            }
        }

        public IEnumerable<BemAlugavel> Listar()
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_BemalugavelListar");
                var BensAlugaveis = new List<BemAlugavel>();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        BensAlugaveis.Add(new BemAlugavel
                        (
                            reader.ReadAsInt("idbem"),
                            reader.ReadAsString("descricao"),
                            reader.ReadAsString("NumPatrimonio"),
                            reader.ReadAsDecimal("vlalugavel")
                        ));
                    }
                cmd.Dispose();
                return BensAlugaveis;
            }
        }

        public void Salvar(BemAlugavel bemAlugavel)
        {
            if (bemAlugavel.IdBem > 0)
                Editar(bemAlugavel);
            else Inserir(bemAlugavel);
        }

        private void Inserir(BemAlugavel bemAlugavel)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_BemalugavelInserir");
                cmd.Parameters.AddWithValue("@nome", bemAlugavel.Descricao);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private void Editar(BemAlugavel bemAlugavel)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_BemalugavelEditar");
                cmd.Parameters.AddWithValue("@descricao", bemAlugavel.Descricao);
                cmd.Parameters.AddWithValue("@NumPatrimonio", bemAlugavel.NumPatrimonio);
                cmd.Parameters.AddWithValue("@vlaluguel", bemAlugavel.VlAluguel);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public BemAlugavel Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
