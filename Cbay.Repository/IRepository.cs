using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;

namespace Cbay.Repository
{
    public interface IRepository : IDisposable
    {
        T Get<T>(int id) where T : class;
        IQueryable<T> GetAll<T>() where T : class;
        void Add<T>(T enity) where T : class;
        void AddRange<T>(IEnumerable<T> entities) where T : class;
        void Update<T>(int id, T entity) where T : class;
        void Delete<T>(int id) where T : class;
    }
}