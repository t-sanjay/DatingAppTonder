using System.Collections.Generic;
using System.Threading.Tasks;
using Tonder.DTOs;
using Tonder.Helpers;
using Tonder.Models;

namespace Tonder.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<LikeDto>> GetUserLikes(LikesParams likesParams);


    }
}
