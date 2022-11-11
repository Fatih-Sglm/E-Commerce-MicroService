namespace E_Commerce.CatalogService.Application.Abstractions.Rules
{
    public abstract class BaseBusinessRules
    {
        public Task CannotNull<T>(T item, string errorMessage)
        {
            if (item is null) throw new Exception(errorMessage);
            return Task.CompletedTask;
        }
    }
}
