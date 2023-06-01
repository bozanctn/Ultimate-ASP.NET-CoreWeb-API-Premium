using Microsoft.AspNetCore.Identity;

public interface IAuthenticationService
{
    Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
    Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
    Task<string> CreateToken();
    Task<TokenDto> CreateToken(bool populateExp);
    Task<TokenDto> RefreshToken(TokenDto tokenDto);

}