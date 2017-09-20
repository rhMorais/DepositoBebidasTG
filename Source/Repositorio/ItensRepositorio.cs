using System;
using System.Collections.Generic;
using Domain;

namespace Repositorio
{
    public class ItensRepositorio : IRepositorio<Itens>
    {
        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Salvar(Itens entidade)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Itens> IRepositorio<Itens>.listar()
        {
            throw new NotImplementedException();
        }
    }
}
