namespace E_Commerce.IdentityService.Application.Features.Auths.Dtos
{
    public class LoginUserDto
    {
        public string UserNameOrEmail { get; set; }
        public string Password { get; set; }
    }
}
