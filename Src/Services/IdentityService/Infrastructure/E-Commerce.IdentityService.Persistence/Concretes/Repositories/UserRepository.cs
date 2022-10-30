using E_Commerce.IdentityService.Application.Abstractions.Repositories;
using E_Commerce.IdentityService.Domain.Entities;
using E_Commerce.IdentityService.Persistence.Concretes.Repositories.GenericRepo;
using E_Commerce.IdentityService.Persistence.Context;

namespace E_Commerce.IdentityService.Persistence.Concretes.Repositories
{
    public class UserRepository : GenericRepoitory<User, IdentityContext>, IUserRepository
    {
        public UserRepository(IdentityContext context) : base(context)
        {
        }
    }
}
