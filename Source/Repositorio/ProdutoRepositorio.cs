using System;
using System.Collections.Generic;
using Domain;

namespace Repositorio 
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {
        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Produto> listar()
        {
            throw new NotImplementedException();
        }

        public void Salvar(Produto entidade)
        {
            throw new NotImplementedException();
        }
    }
}
