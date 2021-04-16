using OperacoesConta.Domain.Data;
using OperacoesConta.Domain.Entities;
using OperacoesConta.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace OperacoesConta.Domain.Repository 
{
    public class ContaRepository : IContaRepository
    {
        private readonly OperacoesContaDbContext _operacoesContaDbContext;
        public ContaRepository(OperacoesContaDbContext operacoesContaDbContext)
        {
            _operacoesContaDbContext = operacoesContaDbContext;
        }
        public void Adicionar(Conta conta)
        {
            _operacoesContaDbContext.Contas.Add(conta);
            _operacoesContaDbContext.SaveChanges();
        }
        public IEnumerable<Conta> ObterTodas()
        {
            return _operacoesContaDbContext.Contas.ToList();
        }
        public IEnumerable<Conta> ObterPorIdentificador(int identifier)
        {
            return _operacoesContaDbContext.Contas
                .Where(p => p.Identifier.Equals(identifier))
                .ToList();
        }
        public IEnumerable<Conta> ObterPorNome(string name)
        {
            return _operacoesContaDbContext.Contas
                .Where(p => p.Identifier.Equals(name))
                .ToList();
        }
    }
}
