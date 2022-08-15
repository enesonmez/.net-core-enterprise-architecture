using System;
using System.Linq.Expressions;
using Core.Entities.Abstract;

namespace Core.DataAccess
{
    // Generic Repository Design Pattern
    // class: referans tip
    // IEntity : IEntity olabilir ya da implemente eden bir nesne olabilir
    // new() : new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null!);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}