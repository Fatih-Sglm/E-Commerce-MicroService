using E_Commerce.OrderService.Domain.AggregaedModels.BuyerAggregate;
using E_Commerce.OrderService.Domain.AggregaedModels.OrderAggregate;
using E_Commerce.OrderService.Domain.SeedWork;
using E_Commerce.OrderService.Persistence.EntitiyConfigurations;
using E_Commerce.OrderService.Persistence.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace E_Commerce.OrderService.Persistence.Contexts
{
    public class OrderContext : DbContext, IUnitOfWork
    {

        public const string DEFAULT_SCHEMA = "ordering";
        private readonly IMediator _mediator;

        public OrderContext(DbContextOptions<OrderContext> options, IServiceProvider provider) : base(options)
        {

            _mediator = provider.GetRequiredService<IMediator>();
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await _mediator.DispatchDomainEventAsync(this);
            await base.SaveChangesAsync();
            return true;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemEntityConfiguration());
            modelBuilder.ApplyConfiguration(new BuyerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusEntityConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentMethodEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CardTypeEntityConfiguration());
        }
    }
}
