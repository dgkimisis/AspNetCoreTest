using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreTest.Services
{

    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AspContext _context;
        private readonly DbSet<T> _entities;

        public Repository(AspContext context) {
            this._context = context;
            this._entities = _context.Set<T>();
        }

        public IList<T> Get()
        {
            return _entities.ToList();
        }

        public void Insert(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }

    }
}
