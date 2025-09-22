using Fretefy.Test.Domain.Entities;
using System.Linq;
using System;

namespace Fretefy.Test.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository
    {
        IQueryable<Regiao> List();
        Regiao Get(Guid id);
        Regiao Add(Regiao regiao);
        Regiao Update(Regiao regiao);
        void Delete(Guid id);
        bool ExisteComNome(string nome);
        bool ExisteComNome(string nome, Guid idExcluir);
    }
}
