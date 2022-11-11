using E_Commerce.OrderService.Application.Abstractions.Repostories.GenericRepo;
using E_Commerce.OrderService.Domain.SeedWork;
using E_Commerce.OrderService.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace E_Commerce.OrderService.Persistence.Concrete.Repository.GenericRepo
{
    public class GenericRepoitory<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly OrderDbContext Context;

        public GenericRepoitory(OrderDbContext context)
        {
            Context = context;
        }

        public IUnitOfWork UnitOfWork => Context;

        public DbSet<T> Table => Context.Set<T>();

        public async Task<T?> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null)
        {
            IQueryable<T> queryable = Table.AsQueryable();
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
            IQueryable<T> queryable = Table.AsQueryable();
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include != null) queryable = include(queryable);
            if (predicate != null) queryable = queryable.Where(predicate);
            if (orderBy != null)
                return await Task.FromResult(orderBy(queryable));
            return await Task.FromResult(queryable);
        }



        public async Task<bool> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.State == EntityState.Added;
        }

        public bool Update(T entity)
        {
            EntityEntry entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }

        public bool Delete(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
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
