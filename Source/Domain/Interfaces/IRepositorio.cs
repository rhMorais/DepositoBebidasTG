using System.Collections.Generic;

namespace Domain
{
    public interface IRepositorio<T>
    {
        void Salvar(T entidade);
        IEnumerable<T> listar();
        void Excluir(int id);
    }
}
