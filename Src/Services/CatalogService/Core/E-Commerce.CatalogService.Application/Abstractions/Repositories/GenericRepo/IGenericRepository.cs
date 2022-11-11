using E_Commerce.CatalogService.Application.Paging;
using E_Commerce.CatalogService.Domain.Entity.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace E_Commerce.CatalogService.Application.Abstractions.Repositories.GenericRepo
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        DbSet<T> Table { get; }
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);

        Task<IPaginate<T>> GetListAsyncPaginate(Expression<Func<T, bool>>? predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                        Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                        int index = 0, int size = 10, bool enableTracking = true,
                                        CancellationToken cancellationToken = default);

        Task<IQueryable<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                        Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null, bool enableTracking = true,
                                        CancellationToken cancellationToken = default);

        //Task<IPaginate<T>> GetListByDynamicAsync(Dynamic.Dynamic dynamic,
        //                                         Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
        //                                         int index = 0, int size = 10, bool enableTracking = true,
        //                                         CancellationToken cancellationToken = default);

        Task AddAsync(T entity);

        Task AddRangeAsync(List<T> datas);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
