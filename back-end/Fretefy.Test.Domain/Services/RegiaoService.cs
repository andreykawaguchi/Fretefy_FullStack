using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;
        private readonly IRegiaoCidadeRepository _regiaoCidadeRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository, IRegiaoCidadeRepository regiaoCidadeRepository)
        {
            _regiaoRepository = regiaoRepository;
            _regiaoCidadeRepository = regiaoCidadeRepository;
        }

        public Regiao Add(Regiao regiao)
        {
            ValidarNomeUnico(regiao.Nome);

            if (regiao.RegiaoCidades != null && regiao.RegiaoCidades.GroupBy(rc => rc.CidadeId).Any(g => g.Count() > 1))
            {
                throw new DomainException("A lista de cidades contém itens duplicados.");
            }

            var regiaoAdicionada = _regiaoRepository.Add(regiao);

            return regiaoAdicionada;
        }

        public void Delete(Guid id)
        {
            var relacionamentos = _regiaoCidadeRepository.GetByRegiaoId(id);
            foreach (var relacionamento in relacionamentos)
            {
                _regiaoCidadeRepository.Delete(relacionamento.Id);
            }

            _regiaoRepository.Delete(id);
        }

        public Regiao Get(Guid id)
        {
            return _regiaoRepository.Get(id);
        }

        public IEnumerable<Regiao> List()
        {
            return _regiaoRepository.List();
        }

        public Regiao Update(Regiao regiao)
        {
            // Validate that the region exists
            var existingRegiao = _regiaoRepository.Get(regiao.Id);
            if (existingRegiao == null)
            {
                throw new DomainException("Região não encontrada.");
            }

            ValidarNomeUnico(regiao.Nome, regiao.Id);

            // Check for duplicate cities in the incoming data
            if (regiao.RegiaoCidades != null && regiao.RegiaoCidades.GroupBy(rc => rc.CidadeId).Any(g => g.Count() > 1))
            {
                throw new DomainException("A lista de cidades contém itens duplicados.");
            }

            // Update the scalar properties first
            var updatedRegiao = _regiaoRepository.Update(regiao);
            if (updatedRegiao == null)
            {
                throw new DomainException("Falha ao atualizar a região.");
            }

            // Handle relationship changes separately
            UpdateRegiaoCidadeRelationships(regiao.Id, regiao.RegiaoCidades);

            // Return the updated region with fresh data
            return _regiaoRepository.Get(regiao.Id);
        }

        private void UpdateRegiaoCidadeRelationships(Guid regiaoId, ICollection<RegiaoCidade> novasRegiaoCidades)
        {
            // Get current relationships
            var relacionamentosAtuais = _regiaoCidadeRepository.GetByRegiaoId(regiaoId).ToList();
            var cidadesAtuais = relacionamentosAtuais.Select(rc => rc.CidadeId).ToList();

            // Get incoming city IDs
            var cidadesNovas = novasRegiaoCidades?.Select(rc => rc.CidadeId).Distinct().ToList() ?? new List<Guid>();

            // Remove relationships that are no longer needed
            var cidadesParaRemover = cidadesAtuais.Except(cidadesNovas).ToList();
            foreach (var cidadeId in cidadesParaRemover)
            {
                var relacionamento = relacionamentosAtuais.FirstOrDefault(rc => rc.CidadeId == cidadeId);
                if (relacionamento != null)
                {
                    _regiaoCidadeRepository.Delete(relacionamento.Id);
                }
            }

            // Add new relationships
            var cidadesParaAdicionar = cidadesNovas.Except(cidadesAtuais).ToList();
            foreach (var cidadeId in cidadesParaAdicionar)
            {
                // Check if relationship already exists (to avoid unique constraint violations)
                if (!_regiaoCidadeRepository.ExisteRelacionamento(regiaoId, cidadeId))
                {
                    var novoRelacionamento = new RegiaoCidade(regiaoId, cidadeId);
                    _regiaoCidadeRepository.Add(novoRelacionamento);
                }
            }
        }

        public void AdicionarCidadeNaRegiao(Guid regiaoId, Guid cidadeId)
        {
            if (_regiaoCidadeRepository.ExisteRelacionamento(regiaoId, cidadeId))
                throw new DomainException("Esta cidade já está associada a esta região.");

            var regiaoCidade = new RegiaoCidade(regiaoId, cidadeId);
            _regiaoCidadeRepository.Add(regiaoCidade);
        }

        public void RemoverCidadeDaRegiao(Guid regiaoId, Guid cidadeId)
        {
            _regiaoCidadeRepository.RemoverPorRegiaoECidade(regiaoId, cidadeId);
        }

        public IEnumerable<Cidade> GetCidadesPorRegiao(Guid regiaoId)
        {
            var relacionamentos = _regiaoCidadeRepository.GetByRegiaoId(regiaoId);
            return relacionamentos.Select(rc => rc.Cidade);
        }

        public void Ativar(Guid id)
        {
            var regiao = _regiaoRepository.Get(id);
            if (regiao == null) throw new DomainException("Região não encontrada.");
            regiao.Ativar();
            _regiaoRepository.Update(regiao);
        }

        public void Desativar(Guid id)
        {
            var regiao = _regiaoRepository.Get(id);
            if (regiao == null) throw new DomainException("Região não encontrada.");
            regiao.Desativar();
            _regiaoRepository.Update(regiao);
        }

        private void ValidarNomeUnico(string nome)
        {
            if (_regiaoRepository.ExisteComNome(nome))
            {
                throw new RegiaoNomeDuplicadoException(nome);
            }
        }

        private void ValidarNomeUnico(string nome, Guid idRegiao)
        {
            if (_regiaoRepository.ExisteComNome(nome, idRegiao))
            {
                throw new RegiaoNomeDuplicadoException(nome);
            }
        }
    }
}
