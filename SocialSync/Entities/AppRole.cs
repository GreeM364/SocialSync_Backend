using Microsoft.AspNetCore.Identity;

namespace SocialSync.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
