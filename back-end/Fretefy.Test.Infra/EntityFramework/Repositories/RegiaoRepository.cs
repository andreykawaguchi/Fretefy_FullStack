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
        private readonly DbContext _context;
        private DbSet<Regiao> _dbSet;

        public RegiaoRepository(DbContext dbContext)
        {
            _context = dbContext;
            _dbSet = dbContext.Set<Regiao>();
        }

        public Regiao Add(Regiao regiao)
        {
            _dbSet.Add(regiao);
            _context.SaveChanges();
            return regiao;
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

        public Regiao Get(Guid id)
        {
            return _dbSet
                .Include(r => r.RegiaoCidades)
                    .ThenInclude(rc => rc.Cidade)
                .FirstOrDefault(r => r.Id == id);
        }

        public IQueryable<Regiao> List()
        {
            return _dbSet
                .Include(r => r.RegiaoCidades)
                    .ThenInclude(rc => rc.Cidade)
                .AsQueryable();
        }

        public Regiao Update(Regiao regiao)
        {
            var existing = _dbSet.Find(regiao.Id);
            if (existing == null)
            {
                return null;
            }

            existing.SetNome(regiao.Nome);
            
            if (existing.Ativo != regiao.Ativo)
            {
                if (regiao.Ativo)
                {
                    existing.Ativar();
                }
                else
                {
                    existing.Desativar();
                }
            }

            _context.SaveChanges();
            
            return Get(regiao.Id);
        }

        public bool ExisteComNome(string nome)
        {
            return _dbSet.Any(r => r.Nome.Trim().ToLower() == nome.Trim().ToLower());
        }

        public bool ExisteComNome(string nome, Guid idExcluir)
        {
            return _dbSet.Any(r => r.Nome.Trim().ToLower() == nome.Trim().ToLower() && r.Id != idExcluir);
        }
    }
}
