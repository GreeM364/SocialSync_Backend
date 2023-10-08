using SocialSync.Entities;

namespace SocialSync.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
