using E_Commerce.CatalogService.Domain.SeedWork;

namespace E_Commerce.CatalogService.Domain.AggregatedModels.CatalogItemAggregate
{
    public class Genders : Enumeration
    {
        public static Genders Unisex = new(1, nameof(Unisex));
        public static Genders Male = new(2, nameof(Male));
        public static Genders Female = new(3, nameof(Female));

        public Genders(int id, string name) : base(id, name)
        {
        }
    }
}
