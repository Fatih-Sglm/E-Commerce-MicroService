﻿namespace E_Commerce.BasketService.Application.Abstractions.Services
{
    public interface IIdentityService
    {
        Task<string> GetUserName();
    }
}
