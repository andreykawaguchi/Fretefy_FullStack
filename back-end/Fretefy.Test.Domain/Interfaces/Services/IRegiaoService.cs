using Fretefy.Test.Domain.Entities;
using System.Collections.Generic;
using System;

namespace Fretefy.Test.Domain.Interfaces
{
    public interface IRegiaoService
    {
        Regiao Get(Guid id);
        IEnumerable<Regiao> List();
        Regiao Add(Regiao regiao);
        Regiao Update(Regiao regiao);
        void Delete(Guid id);
        void AdicionarCidadeNaRegiao(Guid regiaoId, Guid cidadeId);
        void RemoverCidadeDaRegiao(Guid regiaoId, Guid cidadeId);
        IEnumerable<Cidade> GetCidadesPorRegiao(Guid regiaoId);
    }
}
