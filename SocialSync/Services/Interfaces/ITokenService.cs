using SocialSync.Entities;

namespace SocialSync.Services.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
