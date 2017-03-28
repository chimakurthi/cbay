using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Cbay.Repository
{
    public class Repository : IRepository
    {
        private readonly CbayContext _context;

        public Repository()
        {
            if (_context == null)
            {
                _context = new CbayContext();
            }
        }

        public T Get<T>(int id) where T : class 
        {
            return _context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return _context.Set<T>();
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Set<T>().Add(entity);
        }

        public void AddRange<T>(IEnumerable<T> entities) where T : class
        {
            _context.Set<T>().AddRange(entities);
        }

        public void Update<T>(int id, T entity) where T : class
        {
            var existing = Get<T>(id);
            if (existing != null)
            {
                _context.Set<T>().AddOrUpdate(entity);
            }
        }

        public void Delete<T>(int id) where T : class
        {
            var existing = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(existing);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
