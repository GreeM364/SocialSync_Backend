using SocialSync.Entities;

namespace SocialSync.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
