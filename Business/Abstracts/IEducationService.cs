using Business.Dtos.Education.Request;
using Business.Dtos.Education.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IEducationService
    {
        Task<CreatedEducationResponse> AddAsync(CreateEducationRequest createEducationRequest);
        Task<DeletedEducationResponse> DeleteAsync(DeleteEducationRequest deleteEducationRequest);
        Task<UpdatedEducationResponse> UpdateAsync(UpdateEducationRequest updateEducationRequest);
        Task<IPaginate<GetListEducationResponse>> GetListAsync();
        Task<GetByIdEducationResponse> GetByIdAsync(Guid id);
    }

}
