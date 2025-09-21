using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private DbSet<Regiao> _dbSet;

        public RegiaoRepository(DbContext dbContext)
        {
            _dbSet = dbContext.Set<Regiao>();
        }

        public Regiao Add(Regiao regiao)
        {
            _dbSet.Add(regiao);
            return regiao;
        }

        public void Delete(Guid id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
                _dbSet.Remove(entity);
        }

        public Regiao Get(Guid id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<Regiao> List()
        {
            return _dbSet.AsQueryable();
        }

        public Regiao Update(Regiao regiao)
        {
            _dbSet.Update(regiao);
            return regiao;
        }

        public bool ExisteComNome(string nome)
        {
            return _dbSet.Any(r => r.Nome.ToLower() == nome.ToLower());
        }

        public bool ExisteComNome(string nome, Guid idExcluir)
        {
            return _dbSet.Any(r => r.Nome.ToLower() == nome.ToLower() && r.Id != idExcluir);
        }
    }
}
