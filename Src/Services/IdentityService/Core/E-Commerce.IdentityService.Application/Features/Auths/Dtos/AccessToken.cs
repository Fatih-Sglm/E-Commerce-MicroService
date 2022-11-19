namespace E_Commerce.IdentityService.Application.Features.Auths.Dtos
{
    public class AccessToken
    {
        public required string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
