﻿namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Dtos
{
    public class CatalogItemFeaturesDto
    {
        public int Genders { get; set; }
        public int BodySize { get; set; }
        public string? Size { get; set; }
        public uint AvailableStock { get; set; }
    }
}
