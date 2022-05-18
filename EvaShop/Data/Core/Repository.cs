using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace EvaShop.Data.Core
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _dbSet;
        protected readonly DbContext Context;

        protected Repository(DbContext context)
        {
            Context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual TEntity? Get(int id) => _dbSet.Find(id);

        public virtual IEnumerable<TEntity?> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual async Task<TEntity?> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public virtual async Task<IEnumerable<TEntity?>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual IEnumerable<TEntity?> Find(Expression<Func<TEntity?, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public TEntity? SingleOrDefault(Expression<Func<TEntity?, bool>> predicate)
        {
            return _dbSet.SingleOrDefault(predicate);
        }

        public virtual void Add(TEntity? entity)
        {
            if (entity == null) throw new NullReferenceException();
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity?> entities)
        {
            if (entities == null) throw new NullReferenceException();
            _dbSet.AddRange(entities!);
        }

        public void Remove(TEntity? entity)
        {
            if (entity == null) throw new NullReferenceException();
            _dbSet.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
    }
}
