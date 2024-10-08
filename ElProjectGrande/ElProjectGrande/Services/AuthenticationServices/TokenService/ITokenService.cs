using Microsoft.AspNetCore.Identity;

namespace ElProjectGrande.Services.AuthenticationServices.TokenService;

public interface ITokenService
{
    public string CreateToken(IdentityUser user, string role);

    public string ValidateAndGetSessionToken(string sessionToken);
}