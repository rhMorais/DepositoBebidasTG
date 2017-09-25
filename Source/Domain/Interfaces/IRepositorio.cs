using System.Collections.Generic;

namespace Domain
{
    public interface IRepositorio<T>
    {
        void Salvar(T entidade);
        IEnumerable<T> Listar();
        void Excluir(int id);
        T Selecionar(int id);
    }
}
