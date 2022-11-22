namespace E_Commerce.CatalogService.Application.Abstractions.Services
{
    public interface ICatalogBrandService
    {
        Task CheckBrandIsNull(uint Id);
    }
}
