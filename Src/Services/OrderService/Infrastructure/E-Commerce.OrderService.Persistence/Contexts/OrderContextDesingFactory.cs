//using MediatR;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;

//namespace E_Commerce.OrderService.Persistence.Contexts
//{
//    public class OrderContextDesingFactory : IDesignTimeDbContextFactory<OrderDbContext>
//    {
//        string connStr = "Server=.\\SQLEXPRESS;Database=OrderDB;Trusted_Connection=True;";

//        public OrderDbContext CreateDbContext(string[] args)
//        {

//            var optionsbuilder = new DbContextOptionsBuilder<OrderDbContext>().UseSqlServer(connStr);
//            return new OrderDbContext(optionsbuilder.Options, new NoMediator());
//        }
//    }
//    class NoMediator : IMediator
//    {
//        public IAsyncEnumerable<TResponse> CreateStream<TResponse>(IStreamRequest<TResponse> request, CancellationToken cancellationToken = default)
//        {
//            return default;
//        }

//        public IAsyncEnumerable<object> CreateStream(object request, CancellationToken cancellationToken = default)
//        {
//            return default;
//        }

//        public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default(CancellationToken)) where TNotification : INotification
//        {
//            return Task.CompletedTask;
//        }

//        public Task Publish(object notification, CancellationToken cancellationToken = default)
//        {
//            return Task.CompletedTask;
//        }

//        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default(CancellationToken))
//        {
//            return Task.FromResult<TResponse>(default);
//        }

//        public Task<object> Send(object request, CancellationToken cancellationToken = default)
//        {
//            return Task.FromResult<object>(default);
//        }

//    }
//}
