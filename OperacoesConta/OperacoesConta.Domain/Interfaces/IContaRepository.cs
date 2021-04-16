using OperacoesConta.Domain.Entities;
using System.Collections.Generic;

namespace OperacoesConta.Domain.Interfaces
{
    public interface IContaRepository
    {
        void Adicionar(Conta conta);
        IEnumerable<Conta> ObterTodas();
        IEnumerable<Conta> ObterPorIdentificador(int identifier);
        IEnumerable<Conta> ObterPorNome(string name);
    }
}
