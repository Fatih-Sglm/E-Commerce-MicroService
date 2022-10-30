using E_Commerce.OrderService.Application.Abstractions.Repostories.GenericRepo;
using E_Commerce.OrderService.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace E_Commerce.OrderService.Persistence.Concrete.Repository.GenericRepo
{
    public class GenericRepoitory<T, TContext> : IGenericRepository<T> where T : BaseEntity where TContext : DbContext
    {
        public IUnitOfWork UnitOfWork { get; }

        protected TContext Context { get; }

        public GenericRepoitory(TContext context)
        {
            Context = context;
        }

        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        {
            IQueryable<T> queryable = Query();
            if (include != null) queryable = include(queryable);
            return await queryable.FirstOrDefaultAsync(predicate);
        }

        public async Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
                                                           Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy =
                                                               null,
                                                           Func<IQueryable<T>, IIncludableQueryable<T, object>>?
                                                               include = null,
                                                           int index = 0, int size = 10, bool enableTracking = true,
                                                           CancellationToken cancellationToken = default)
        {
            IQueryable<T> queryable = Query();
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include != null) queryable = include(queryable);
            if (predicate != null) queryable = queryable.Where(predicate);
            if (orderBy != null)
                return await Task.FromResult(orderBy(queryable));
            return await Task.FromResult(queryable);
        }

        public IQueryable<T> Query()
        {
            return Context.Set<T>();
        }

        public async Task<bool> AddAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            return true;
        }

        public bool Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return true;
        }

        public bool Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return true;
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().FirstOrDefault(predicate);
        }

        public async Task AddRangeAsync(List<T> datas)
        {
            await Context.AddRangeAsync(datas);
        }
    }
}
