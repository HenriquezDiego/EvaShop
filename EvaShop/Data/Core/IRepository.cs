﻿using System.Linq.Expressions;

namespace EvaShop.Data.Core
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity? Get(int id);
        Task<TEntity?> GetAsync(int id);
        IEnumerable<TEntity?> GetAll();
        Task<IEnumerable<TEntity?>> GetAllAsync();
        IEnumerable<TEntity?> Find(Expression<Func<TEntity?, bool>> predicate);
        TEntity? SingleOrDefault(Expression<Func<TEntity?, bool>> predicate);
        void Add(TEntity? entity);
        void AddRange(IEnumerable<TEntity?> entities);
        void Remove(TEntity? entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
