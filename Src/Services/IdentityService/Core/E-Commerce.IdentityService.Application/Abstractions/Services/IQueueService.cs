namespace E_Commerce.IdentityService.Application.Abstractions.Services
{
    public interface IQueueService<T>
    {
        Task AddQueue(T item);
        Task<T> DeQueue(CancellationToken cancellationToken);
    }
}
