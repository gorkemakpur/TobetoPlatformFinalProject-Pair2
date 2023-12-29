using Business.Dtos.Student.Request;
using Business.Dtos.Student.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IStudentService
    {
        Task<CreatedStudentResponse> AddAsync(CreateStudentRequest createStudentRequest);
        Task<DeletedStudentResponse> DeleteAsync(DeleteStudentRequest deleteStudentRequest);
        Task<UpdatedStudentResponse> UpdateAsync(UpdateStudentRequest updateStudentRequest);
        Task<IPaginate<GetListStudentResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdStudentResponse> GetByIdAsync(Guid id);
    }

}
