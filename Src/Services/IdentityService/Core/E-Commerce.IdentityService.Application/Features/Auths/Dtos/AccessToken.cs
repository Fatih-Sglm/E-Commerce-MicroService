namespace E_Commerce.IdentityService.Application.Features.Auths.Dtos
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
