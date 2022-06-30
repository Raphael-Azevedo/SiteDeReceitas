using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace desafio_mvc.Repository.Interfaces
{
    public interface IRepository<T>
    {
        IQueryable<T> Get();
        T GetById(Expression<Func<T,bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete (T entity);
    }
}