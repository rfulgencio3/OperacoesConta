using System;

namespace OperacoesConta.Domain.Entities
{
    public class Conta
    {
        public int Identifier { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Conta(int identifier, string name, string description, string status)
        {
            Identifier = identifier;
            Name = name;
            Description = description;
            Status = status;
        }

        public void ValidarNome(Conta conta)
        {
            if (string.IsNullOrEmpty(conta.Name.ToString()))
            {
                throw new ArgumentException("Nome de conta não encontrado.");
            }
        }
    }
}
