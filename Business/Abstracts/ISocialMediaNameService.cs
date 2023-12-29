using Business.Dtos.SocialMediaName.Request;
using Business.Dtos.SocialMediaName.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISocialMediaNameService
    {
        Task<CreatedSocialMediaNameResponse> AddAsync(CreateSocialMediaNameRequest createSocialMediaNameRequest);
        Task<DeletedSocialMediaNameResponse> DeleteAsync(DeleteSocialMediaNameRequest deleteSocialMediaNameRequest);
        Task<UpdatedSocialMediaNameResponse> UpdateAsync(UpdateSocialMediaNameRequest updateSocialMediaNameRequest);
        Task<IPaginate<GetListSocialMediaNameResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdSocialMediaNameResponse> GetByIdAsync(Guid id);
    }

}
