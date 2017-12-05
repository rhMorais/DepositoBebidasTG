using Domain;
using Repositorio;
using System;
using System.Linq;

namespace Services
{
    public class ClienteService
    {
        private readonly ClienteRepositorio _repo = new ClienteRepositorio();
        private readonly ItemAlugavelRepositorio _repoItemAlugavel = new ItemAlugavelRepositorio();

        public Response Salvar(Cliente cliente)
        {
            if (IsNullOrEmpty(cliente.Nome) || cliente.Nome.Length < 4)
                return new Response("O nome deve conter pelo menos 4 caracteres!", 400);
            if (IsNullOrEmpty(cliente.Cpf) || cliente.Cpf.Length != 11)
                return new Response("Informe um CPF válido!", 400);
            if (IsNullOrEmpty(cliente.Endereco))
                return new Response("Informe um Endereço!", 400);
            if (IsNullOrEmpty(cliente.Celular))
                return new Response("Informe um Celular!", 400);

            _repo.Salvar(cliente);
            return new Response("Cliente salvo com sucesso!", 200);
        }

        public Response Excluir(int id)
        {
            //verificar se o cliente possui algum aluguel ativo
            var alugueis = _repoItemAlugavel.listar().ToList().Where(aluguel => 
                            aluguel.Inicio < DateTime.Today && 
                            aluguel.Fim > DateTime.Today && 
                            aluguel.Pedido.Cliente.IdCli == id);

            if (alugueis != null || alugueis.Any())
            {
                _repo.Excluir(id);
                return new Response("Cliente exluído com sucesso", 200);
            }
            return new Response("Não foi possível excluir o cliente pois ele possui aluguel ativo", 400);    
        }

        private bool IsNullOrEmpty(string str)
        {
            if (str == null || str.Trim() == "")
                return true;
            return false;
        }
    }
}
