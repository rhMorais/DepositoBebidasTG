using System;
using System.Collections.Generic;
using Domain;
using Deposito_TG.Repositorio;
using Concessionaria.Repositorio;

namespace Repositorio
{
    public class VendedorRepositorio : IRepositorio<Vendedor>
    {
        private Contexto contexto;        

        public void Excluir(int id)
        {
            using (contexto = new Contexto())
            {
                var del = contexto.ExecutaProcedure("TGDB_VendedorExcluir");
                del.Parameters.AddWithValue("@idven", id);
                del.ExecuteNonQuery();
                del.Dispose();            
            }
        }

        public IEnumerable<Vendedor> Listar()
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_VendedorListar");
                var vendedores = new List<Vendedor>();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        vendedores.Add(new Vendedor
                        (
                            reader.ReadAsInt("idven"),
                            reader.ReadAsString("nome"),
                            reader.ReadAsString("telefone"),
                            reader.ReadAsString("celular"),
                            reader.ReadAsString("empresa")
                        ));
                    }
                cmd.Dispose();
                return vendedores;
            }
        }

        public void Salvar(Vendedor vendedor)
        {
            if (vendedor.IdVen > 0)
                Editar(vendedor);
            else Inserir(vendedor);
        }

        private void Inserir(Vendedor vendedor)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_VendedorInserir");
                cmd.Parameters.AddWithValue("@nome", vendedor.Nome);
                cmd.Parameters.AddWithValue("@telefone", vendedor.Telefone);
                cmd.Parameters.AddWithValue("@celular", vendedor.Celular);
                cmd.Parameters.AddWithValue("@empresa", vendedor.Empresa);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private void Editar(Vendedor vendedor)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_VendedorEditar");
                cmd.Parameters.AddWithValue("@nome", vendedor.Nome);
                cmd.Parameters.AddWithValue("@nome", vendedor.Nome);
                cmd.Parameters.AddWithValue("@telefone", vendedor.Telefone);
                cmd.Parameters.AddWithValue("@celular", vendedor.Celular);
                cmd.Parameters.AddWithValue("@empresa", vendedor.Empresa);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public Vendedor Selecionar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
