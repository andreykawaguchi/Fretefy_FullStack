using Fretefy.Test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoCidadeRepository
    {
        IQueryable<RegiaoCidade> List();
        RegiaoCidade Get(Guid id);
        RegiaoCidade Add(RegiaoCidade regiaoCidade);
        RegiaoCidade Update(RegiaoCidade regiaoCidade);
        void Delete(Guid id);
        IEnumerable<RegiaoCidade> GetByRegiaoId(Guid regiaoId);
        IEnumerable<RegiaoCidade> GetByCidadeId(Guid cidadeId);
        bool ExisteRelacionamento(Guid regiaoId, Guid cidadeId);
        void RemoverPorRegiaoECidade(Guid regiaoId, Guid cidadeId);
    }
}