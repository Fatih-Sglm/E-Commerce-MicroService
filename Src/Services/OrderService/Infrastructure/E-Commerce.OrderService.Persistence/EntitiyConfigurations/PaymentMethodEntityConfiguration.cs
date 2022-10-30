using E_Commerce.OrderService.Domain.AggregaedModels.BuyerAggregate;
using E_Commerce.OrderService.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_Commerce.OrderService.Persistence.EntitiyConfigurations
{
    internal class PaymentMethodEntityConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> paymentConfiguration)
        {
            paymentConfiguration.ToTable("paymentmethods", OrderContext.DEFAULT_SCHEMA);

            paymentConfiguration.Ignore(b => b.DomainEvents);

            paymentConfiguration.HasKey(o => o.Id);
            paymentConfiguration.Property(i => i.Id).HasColumnName("Id");

            paymentConfiguration.Property<int>("BuyerId")
                .IsRequired();

            paymentConfiguration
                .Property(i => i.CardHolderName)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("CardHolderName")
                .HasMaxLength(200)
                .IsRequired();

            paymentConfiguration
                .Property(i => i.Alias)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Alias")
                .HasMaxLength(200)
                .IsRequired();

            paymentConfiguration
                .Property(i => i.CardNumber)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("CardNumber")
                .HasMaxLength(25)
                .IsRequired();

            paymentConfiguration
                .Property(i => i.Expiration)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Expiration")
                .HasMaxLength(25)
                .IsRequired();

            paymentConfiguration
                .Property(i => i.CardTypeId)
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("CardTypeId")
                .IsRequired();

            paymentConfiguration.HasOne(p => p.CardType)
                .WithMany()
                .HasForeignKey(i => i.CardTypeId);
        }
    }
}
