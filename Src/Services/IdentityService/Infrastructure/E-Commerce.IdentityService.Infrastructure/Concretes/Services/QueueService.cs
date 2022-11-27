using E_Commerce.IdentityService.Application.Abstractions.Services;
using System.Threading.Channels;

namespace E_Commerce.IdentityService.Infrastructure.Concretes.Services
{
    public class QueueService<T> : IQueueService<T>
    {
        private readonly Channel<T> _channel;
        public QueueService()
        {
            _channel = Channel.CreateUnbounded<T>();

        }
        public async Task AddQueue(T item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));
            await _channel.Writer.WriteAsync(item);
        }

        public async Task<T> DeQueue(CancellationToken cancellationToken)
        {
            return await _channel.Reader.ReadAsync(cancellationToken);
        }
    }
}
