using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fretefy.Test.Infra.EntityFramework.Repositories
{
    public class RegiaoCidadeRepository : IRegiaoCidadeRepository
    {
        private readonly DbContext _context;
        private readonly DbSet<RegiaoCidade> _dbSet;

        public RegiaoCidadeRepository(DbContext dbContext)
        {
            _context = dbContext;
            _dbSet = dbContext.Set<RegiaoCidade>();
        }

        public RegiaoCidade Add(RegiaoCidade regiaoCidade)
        {
            _dbSet.Add(regiaoCidade);
            _context.SaveChanges();
            return regiaoCidade;
        }

        public void Delete(Guid id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public RegiaoCidade Get(Guid id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<RegiaoCidade> List()
        {
            return _dbSet.AsQueryable();
        }

        public RegiaoCidade Update(RegiaoCidade regiaoCidade)
        {
            _dbSet.Update(regiaoCidade);
            _context.SaveChanges();
            return regiaoCidade;
        }

        public IEnumerable<RegiaoCidade> GetByRegiaoId(Guid regiaoId)
        {
            return _dbSet.Where(rc => rc.RegiaoId == regiaoId).ToList();
        }

        public IEnumerable<RegiaoCidade> GetByCidadeId(Guid cidadeId)
        {
            return _dbSet.Where(rc => rc.CidadeId == cidadeId).ToList();
        }

        public bool ExisteRelacionamento(Guid regiaoId, Guid cidadeId)
        {
            return _dbSet.Any(rc => rc.RegiaoId == regiaoId && rc.CidadeId == cidadeId);
        }

        public void RemoverPorRegiaoECidade(Guid regiaoId, Guid cidadeId)
        {
            var relacionamento = _dbSet.FirstOrDefault(rc => rc.RegiaoId == regiaoId && rc.CidadeId == cidadeId);
            if (relacionamento != null)
            {
                _dbSet.Remove(relacionamento);
                _context.SaveChanges();
            }
        }
    }
}