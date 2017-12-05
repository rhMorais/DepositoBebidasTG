using Concessionaria.Repositorio;
using Deposito_TG.Repositorio;
using Domain;
using System;
using System.Collections.Generic;

namespace Repositorio
{
    public class ClienteRepositorio : IRepositorio<Cliente>
    {
        private Contexto contexto;

        public void Excluir(int id)
        {
            using (contexto = new Contexto())
            {
                var del = contexto.ExecutaProcedure("TGDB_ClienteExcluir");
                del.Parameters.AddWithValue("@idcli", id);
                del.ExecuteNonQuery();
                del.Dispose();
            }
        }

        public IEnumerable<Cliente> Listar()
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_ClienteListar");
                var clientees = new List<Cliente>();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        clientees.Add(new Cliente
                        (
                            reader.ReadAsInt("idcli"),
                            reader.ReadAsString("nome"),
                            reader.ReadAsString("cpf"),
                            reader.ReadAsString("endereco"),
                            reader.ReadAsString("bairro"),
                            reader.ReadAsString("cidade"),
                            reader.ReadAsString("telefone"),
                            reader.ReadAsString("celular"),
                            reader.ReadAsString("email")
                        ));
                    }
                cmd.Dispose();
                return clientees;
            }
        }

        public void Salvar(Cliente cliente)
        {
            if (cliente.IdCli > 0)
                Editar(cliente);
            else Inserir(cliente);
        }

        private void Inserir(Cliente cliente)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_ClienteInserir");
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private void Editar(Cliente cliente)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_ClienteEditar");
                cmd.Parameters.AddWithValue("@idcli", cliente.IdCli);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
                cmd.Parameters.AddWithValue("@bairro", cliente.Bairro);
                cmd.Parameters.AddWithValue("@cidade", cliente.Cidade);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@celular", cliente.Celular);
                cmd.Parameters.AddWithValue("@email", cliente.Email);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        public Cliente Selecionar(int id)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_ClienteSelecionar");
                cmd.Parameters.AddWithValue("@idCliente", id);
                Cliente cliente = new Cliente();
                using (var reader = cmd.ExecuteReader())
                    if (reader.Read())
                        cliente = new Cliente
                        (
                            reader.ReadAsInt("idcli"),
                            reader.ReadAsString("nome"),
                            reader.ReadAsString("cpf"),
                            reader.ReadAsString("endereco"),
                            reader.ReadAsString("bairro"),
                            reader.ReadAsString("cidade"),
                            reader.ReadAsString("telefone"),
                            reader.ReadAsString("celular"),
                            reader.ReadAsString("email")
                        );
                cmd.Dispose();
                return cliente;
            }
        }
    }
}
