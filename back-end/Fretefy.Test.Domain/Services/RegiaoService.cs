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
            var regiaoAdicionada = _regiaoRepository.Add(regiao);
            
            // Adicionar relacionamentos com cidades se existirem
            foreach (var regiaoCidade in regiao.RegiaoCidades)
            {
                _regiaoCidadeRepository.Add(regiaoCidade);
            }
            
            return regiaoAdicionada;
        }

        public void Delete(Guid id)
        {
            // Primeiro remove os relacionamentos
            var relacionamentos = _regiaoCidadeRepository.GetByRegiaoId(id);
            foreach (var relacionamento in relacionamentos)
            {
                _regiaoCidadeRepository.Delete(relacionamento.Id);
            }
            
            // Depois remove a região
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
            ValidarNomeUnico(regiao.Nome, regiao.Id);
            return _regiaoRepository.Update(regiao);
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
