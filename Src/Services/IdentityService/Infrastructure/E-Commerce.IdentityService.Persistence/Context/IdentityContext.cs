using E_Commerce.IdentityService.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.IdentityService.Persistence.Context
{
    public class IdentityContext : DbContext
    {
        public IdentityContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}
