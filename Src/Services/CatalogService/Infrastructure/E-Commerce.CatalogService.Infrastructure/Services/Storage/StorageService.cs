﻿using E_Commerce.CatalogService.Application.Abstractions.Storage;
using Microsoft.AspNetCore.Http;

namespace E_Commerce.CatalogService.Infrastructure.Services.Storage
{
    public class StorageService : IStorageService
    {
        private readonly IStorage _storage;

        public StorageService(IStorage storage)
        {
            _storage = storage;
        }

        public string StorageName => _storage.GetType().Name;

        public Task DeleteAsync(string pathOrContainerName, string fileName) => _storage.DeleteAsync(pathOrContainerName, fileName);

        public string? GetFile(string pathOrContainerName, string fileName) => _storage.GetFile(pathOrContainerName, fileName);

        public bool HasFile(string pathOrContainerName, string fileName) => _storage.HasFile(pathOrContainerName, fileName);

        public Task<List<(string fileName, string pathOrContainerName)>> UploadAsync(string pathOrContainerName, IFormFileCollection files)
            => _storage.UploadAsync(pathOrContainerName, files);
    }
}
