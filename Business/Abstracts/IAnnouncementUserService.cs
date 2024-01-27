using Business.Dtos.AnnouncementUser.Request;
using Business.Dtos.AnnouncementUser.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAnnouncementUserService 
    {
        Task<CreatedAnnouncementUserResponse> AddAsync(CreateAnnouncementUserRequest createAnnouncementUserRequest);
        Task<DeletedAnnouncementUserResponse> DeleteAsync(DeleteAnnouncementUserRequest deleteAnnouncementUserRequest);
        Task<UpdatedAnnouncementUserResponse> UpdateAsync(UpdateAnnouncementUserRequest updateAnnouncementUserRequest);
        Task<IPaginate<GetListAnnouncementUserResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdAnnouncementUserResponse> GetByIdAsync(Guid id);
    }
}
