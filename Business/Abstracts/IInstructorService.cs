using Business.Dtos.Instructor.Request;
using Business.Dtos.Instructor.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest);
        Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest);
        Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest);
        Task<IPaginate<GetListInstructorResponse>> GetListAsync();
        Task<GetByIdInstructorResponse> GetByIdAsync(Guid id);
    }
}
