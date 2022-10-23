namespace E_Commerce.CatalogService.Domain.Entity.Base
{
    public interface IEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
