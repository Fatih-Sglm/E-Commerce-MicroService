using Microsoft.AspNetCore.Identity;

namespace E_Commerce.IdentityService.Domain.Entities.Identity
{
    public class AppUser : IdentityUser<Guid>, IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
