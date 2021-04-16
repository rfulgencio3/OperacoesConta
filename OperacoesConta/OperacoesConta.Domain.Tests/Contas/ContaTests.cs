using OperacoesConta.Domain.Entities;
using System;
using Xunit;

namespace OperacoesConta.Domain.Tests.Contas
{
    public class ContaTests
    {
        [Fact(DisplayName = "Validar Informações de Criação de Conta")]
        [Trait("Categoria", "Conta - Criar Conta")]
        public void Conta_Criar_ValidarInformacoes()
        {
            // Arrange && Act
            var novaConta = new Conta(1, "Conta do Fulgencio", "Conta Salário", "ACTIVE");

            // Assert
            Assert.Equal(1, novaConta.Identifier);
            Assert.Equal("Conta do Fulgencio", novaConta.Name);
            Assert.Equal("Conta Salário", novaConta.Description);
            Assert.Equal("ACTIVE", novaConta.Status);
        }

        [Fact(DisplayName = "Retornar Erro de Criação de Conta sem Nome")]
        [Trait("Categoria", "Conta - Criar Conta")]
        public void Conta_VerificarContaSemNome_DeveRetornarException()
        {
            // Arrange && Act
            var novaConta = new Conta(2, "", "Conta Salário", "ACTIVE");

            // Assert
            Assert.Throws<ArgumentException>(() => novaConta.ValidarNome(novaConta));
        }
    }
}
