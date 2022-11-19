﻿using E_Commerce.CatalogService.Domain.Entities.Common;

namespace E_Commerce.CatalogService.Domain.Entities
{
    public class CatalogType : BaseEntity<uint>
    {
        public string Name { get; set; }
        public ICollection<CatalogItem>? CatalogItems { get; set; }
    }
}
