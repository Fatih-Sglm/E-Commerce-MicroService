namespace E_Commerce.IdentityService.Application.Features.Auths.Dtos
{
    public class LoginResponseDto : AccessToken
    {
        public required string RefreshToken { get; set; }
    }
}
