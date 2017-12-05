using Concessionaria.Repositorio;
using Deposito_TG.Repositorio;
using Domain;
using System;
using System.Collections.Generic;

namespace Repositorio
{
    public class AtendenteRepositorio : IRepositorio<Atendente>
    {
        private Contexto contexto;

        public void Excluir(int id)
        {
            using (contexto = new Contexto())
            {
                var del = contexto.ExecutaProcedure("TGDB_AtendenteExcluir");
                del.Parameters.AddWithValue("@idaten", id);
                del.ExecuteNonQuery();
                del.Dispose();
            }
        }

        public IEnumerable<Atendente> Listar()
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_AtendenteListar");
                var atendentees = new List<Atendente>();
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        atendentees.Add(new Atendente
                        (
                            reader.ReadAsInt("idaten"),
                            reader.ReadAsString("nome")
                        ));
                    }
                cmd.Dispose();
                return atendentees;
            }
        }

        public Atendente Selecionar(int idaten)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_AtendenteSelecionar");
                cmd.Parameters.AddWithValue("@idaten", idaten);
                var atendente = new Atendente();
                using (var reader = cmd.ExecuteReader())
                    if (reader.Read())
                        atendente = new Atendente
                        (
                            reader.ReadAsInt("idaten"),
                            reader.ReadAsString("nome")
                        );                        
                cmd.Dispose();
                return atendente;
            }
        }

        public void Salvar(Atendente atendente)
        {
            if (atendente.IdAten > 0)
                Editar(atendente);
            else Inserir(atendente);
        }

        private void Inserir(Atendente atendente)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_AtendenteInserir");
                cmd.Parameters.AddWithValue("@nome", atendente.Nome);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }

        private void Editar(Atendente atendente)
        {
            using (contexto = new Contexto())
            {
                var cmd = contexto.ExecutaProcedure("TGDB_AtendenteEditar");
                cmd.Parameters.AddWithValue("@idaten", atendente.IdAten);
                cmd.Parameters.AddWithValue("@nome", atendente.Nome);                
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
        }
    }
}
