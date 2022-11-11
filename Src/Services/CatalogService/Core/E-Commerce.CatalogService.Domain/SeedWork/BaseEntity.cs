namespace E_Commerce.CatalogService.Domain.SeedWork
{
    public abstract class BaseEntity<T> : IEntity
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
