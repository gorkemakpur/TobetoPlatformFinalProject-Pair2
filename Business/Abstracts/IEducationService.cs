using Business.Dtos.Category.Request;
using Business.Dtos.Category.Response;
using Business.Dtos.Education.Request;
using Business.Dtos.Education.Response;
using Business.Dtos.Instructor.Response;
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
