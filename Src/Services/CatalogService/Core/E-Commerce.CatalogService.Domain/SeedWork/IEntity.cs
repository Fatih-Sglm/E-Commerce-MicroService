namespace E_Commerce.CatalogService.Domain.SeedWork
{
    public interface IEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
