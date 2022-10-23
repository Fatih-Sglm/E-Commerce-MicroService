using E_Commerce.CatalogService.Application.Abstractions.Repositories.GenericRepo;
using E_Commerce.CatalogService.Application.Paging;
using E_Commerce.CatalogService.Domain.Entity.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace E_Commerce.CatalogService.Persistence.Concretes.Repositories.GenericRepo
{
    public class GenericRepoitory<T, TContext> : IGenericRepository<T>
    where T : class, IEntity
    where TContext : DbContext
    {
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

        public async Task<IPaginate<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
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
                return await orderBy(queryable).ToPaginateAsync(index, size, 0, cancellationToken);
            return await queryable.ToPaginateAsync(index, size, 0, cancellationToken);
        }

        public async Task<IQueryable<T>> GetAllIQueryableAsync(Expression<Func<T, bool>>? predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, int index = 0, int size = 10, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<T> queryable = Query();
            if (!enableTracking) queryable = queryable.AsNoTracking();
            if (include != null) queryable = include(queryable);
            if (predicate != null) queryable = queryable.Where(predicate);
            if (orderBy != null)
                return await Task.FromResult(orderBy(queryable));
            return await Task.FromResult(queryable);
        }

        //public async Task<IPaginate<T>> GetListByDynamicAsync(Dynamic.Dynamic dynamic,
        //                                                            Func<IQueryable<T>,
        //                                                                    IIncludableQueryable<T, object>>?
        //                                                                include = null,
        //                                                            int index = 0, int size = 10,
        //                                                            bool enableTracking = true,
        //                                                            CancellationToken cancellationToken = default)
        //{
        //    IQueryable<T> queryable = Query().AsQueryable().ToDynamic(dynamic);
        //    if (!enableTracking) queryable = queryable.AsNoTracking();
        //    if (include != null) queryable = include(queryable);
        //    return await queryable.ToPaginateAsync(index, size, 0, cancellationToken);
        //}

        public IQueryable<T> Query()
        {
            return Context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Added;
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            await Context.SaveChangesAsync();
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().FirstOrDefault(predicate);
        }

        public async Task AddRangeAsync(List<T> datas)
        {
            await Context.AddRangeAsync(datas);
            await Context.SaveChangesAsync();
        }
    }
}
