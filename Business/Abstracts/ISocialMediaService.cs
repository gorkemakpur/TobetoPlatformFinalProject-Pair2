using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.SocialMedia.Request;
using Business.Dtos.SocialMedia.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISocialMediaService
    {
        Task<CreatedSocialMediaResponse> AddAsync(CreateSocialMediaRequest createSocialMediaRequest);
        Task<DeletedSocialMediaResponse> DeleteAsync(DeleteSocialMediaRequest deleteSocialMediaRequest);
        Task<UpdatedSocialMediaResponse> UpdateAsync(UpdateSocialMediaRequest updateSocialMediaRequest);
        Task<IPaginate<GetListSocialMediaResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdSocialMediaResponse> GetByIdAsync(Guid id);
    }

}
