namespace Domain
{
    public class Cliente
    {
        public Cliente(int idCli, string nome, string cpf, string endereco, string bairro, string cidade, string telefone, string celular, string email)
        {
            IdCli = idCli;
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
            Bairro = bairro;
            Cidade = cidade;
            Telefone = telefone;
            Celular = celular;
            Email = email;
        }

        public int IdCli { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
    }
}
