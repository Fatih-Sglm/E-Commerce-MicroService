﻿using E_Commerce.CatalogService.Domain.Entities;

namespace E_Commerce.CatalogService.Application.Features.CatalogItems.Rules
{
    public static class CatalogItemBusinessRule
    {
        public static Task CannotNull(this CatalogItem item, string errorMessage)
        {
            if (item is null) throw new Exception(errorMessage);
            return Task.CompletedTask;
        }
    }
}
