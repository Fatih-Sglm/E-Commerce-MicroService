using E_Commerce.CatalogService.Domain.SeedWork;

namespace E_Commerce.CatalogService.Domain.AggregatedModels.CatalogItemAggregate
{
    public class BodySize : Enumeration
    {
        public static BodySize S = new(1, nameof(S));
        public static BodySize M = new(2, nameof(M));
        public static BodySize L = new(3, nameof(L));
        public static BodySize XL = new(1, nameof(XL));
        public static BodySize XXL = new(2, nameof(XXL));

        public BodySize(int id, string name) : base(id, name)
        {
        }
    }
}
