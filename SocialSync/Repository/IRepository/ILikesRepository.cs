using SocialSync.DTOs;
using SocialSync.Entities;
using SocialSync.Helpers.Pagination;

namespace SocialSync.Repository.IRepository
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);
    }
}
