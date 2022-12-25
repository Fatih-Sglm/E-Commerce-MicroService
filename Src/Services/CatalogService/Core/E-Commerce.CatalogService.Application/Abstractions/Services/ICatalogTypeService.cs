﻿using E_Commerce.CatalogService.Application.Features.CatalogTypes.Dto;

namespace E_Commerce.CatalogService.Application.Abstractions.Services
{
    public interface ICatalogTypeService
    {
        Task<GetCatalogTypeDto> GetCategoryById(uint id);
        Task<List<GetCatalogTypeDto>> GetCatalogTypes();
    }
}
