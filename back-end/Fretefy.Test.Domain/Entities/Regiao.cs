using System;
using System.Collections.Generic;
using System.Linq;
using Fretefy.Test.Domain.Exceptions;

namespace Fretefy.Test.Domain.Entities
{
    public class Regiao : IEntity
    {
        public Regiao()
        {
            RegiaoCidades = new List<RegiaoCidade>();
            Ativo = true;
        }

        public Regiao(string nome) : this()
        {
            Id = Guid.NewGuid();
            SetNome(nome);
        }

        public Guid Id { get; set; }

        public string Nome { get; private set; }

        public bool Ativo { get; private set; }

        public ICollection<RegiaoCidade> RegiaoCidades { get; set; }

        public void SetNome(string nome)
        {
            ValidarNome(nome);
            Nome = nome;
        }

        private void ValidarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new DomainException("O nome da região é obrigatório.");

            if (nome.Length > 100)
                throw new DomainException("O nome da região não pode ter mais de 100 caracteres.");
        }

        public void AdicionarCidade(Cidade cidade)
        {
            if (cidade == null)
                throw new DomainException("A cidade não pode ser nula.");

            var regiaoCidade = new RegiaoCidade(Id, cidade.Id);
            RegiaoCidades.Add(regiaoCidade);
        }

        public void RemoverCidade(Guid cidadeId)
        {
            var regiaoCidade = RegiaoCidades.FirstOrDefault(rc => rc.CidadeId == cidadeId);
            if (regiaoCidade != null)
            {
                RegiaoCidades.Remove(regiaoCidade);
            }
        }

        public void Ativar()
        {
            Ativo = true;
        }

        public void Desativar()
        {
            Ativo = false;
        }
    }
}
