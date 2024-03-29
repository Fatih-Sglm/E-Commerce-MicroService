﻿namespace E_Commerce.CatalogService.Domain.Entities.Common
{
    public abstract class BaseEntity<T> : IEntity
    {
        public T Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
