using Microsoft.EntityFrameworkCore;
using OperacoesConta.Domain.Entities;

namespace OperacoesConta.Domain.Data
{
    public class OperacoesContaDbContext : DbContext
    {
        public DbSet<Conta> Contas { get; set; }

        public OperacoesContaDbContext(DbContextOptions<OperacoesContaDbContext> options) 
            : base(options) { }
    }
}
