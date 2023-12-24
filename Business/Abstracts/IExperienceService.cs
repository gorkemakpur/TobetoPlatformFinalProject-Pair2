using Business.Dtos.Experience.Request;
using Business.Dtos.Experience.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IExperienceService
    {
        Task<CreatedExperienceResponse> AddAsync(CreateExperienceRequest createExperienceRequest);
        Task<DeletedExperienceResponse> DeleteAsync(DeleteExperienceRequest deleteExperienceRequest);
        Task<UpdatedExperienceResponse> UpdateAsync(UpdateExperienceRequest updateExperienceRequest);
        Task<IPaginate<GetListExperienceResponse>> GetListAsync();
        Task<GetByIdExperienceResponse> GetByIdAsync(Guid id);
    }

}
