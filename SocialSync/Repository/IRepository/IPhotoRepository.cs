using SocialSync.DTOs;
using SocialSync.Entities;

namespace SocialSync.Repository.IRepository
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<PhotoForApprovalDto>> GetUnapprovedPhotos();
        Task<Photo> GetPhotoById(int id);
        void RemovePhoto(Photo photo);
    }
}
