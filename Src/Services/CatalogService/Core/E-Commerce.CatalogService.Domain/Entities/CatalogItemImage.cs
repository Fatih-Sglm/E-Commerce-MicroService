﻿using E_Commerce.CatalogService.Domain.Entities.Common;

namespace E_Commerce.CatalogService.Domain.Entities
{
    public class CatalogItemImage : BaseEntity<uint>
    {
        public string FileName { get; set; }
        public string Path { get; set; }
        public bool IsHeader { get; set; } = false;
        public CatalogItem CatalogItem { get; set; }
        public uint CatalogItemId { get; set; }
    }
}
