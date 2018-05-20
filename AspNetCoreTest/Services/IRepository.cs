using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreTest.Models;

namespace AspNetCoreTest.Services
{
    public interface IRepository<T> where T : BaseEntity
    {
        IList<T> Get();
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
