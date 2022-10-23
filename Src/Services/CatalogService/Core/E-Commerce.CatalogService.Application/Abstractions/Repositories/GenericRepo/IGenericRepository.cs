using E_Commerce.CatalogService.Application.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace E_Commerce.CatalogService.Application.Abstractions.Repositories.GenericRepo
{
    public interface IGenericRepository<T>
    {
        Task<T?> GetAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null);

        Task<IPaginate<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                        Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                        int index = 0, int size = 10, bool enableTracking = true,
                                        CancellationToken cancellationToken = default);

        Task<IQueryable<T>> GetAllIQueryableAsync(Expression<Func<T, bool>>? predicate = null,
                                        Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                                        Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
                                        int index = 0, int size = 10, bool enableTracking = true,
                                        CancellationToken cancellationToken = default);

        //Task<IPaginate<T>> GetListByDynamicAsync(Dynamic.Dynamic dynamic,
        //                                         Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
        //                                         int index = 0, int size = 10, bool enableTracking = true,
        //                                         CancellationToken cancellationToken = default);

        Task AddAsync(T entity);

        Task AddRangeAsync(List<T> datas);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        IQueryable<T> Query();
    }
}
