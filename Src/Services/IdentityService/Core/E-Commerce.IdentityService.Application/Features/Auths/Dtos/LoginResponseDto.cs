namespace E_Commerce.IdentityService.Application.Features.Auths.Dtos
{
    public class LoginResponseDto
    {
        public required string Token { get; set; }
        public string Expiration { get; set; }
        public required string RefreshToken { get; set; }
    }
}
