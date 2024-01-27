using Business.Dtos.StudentInformation.Request;
using Business.Dtos.StudentInformation.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IStudentInformationService
    {
        Task<CreatedStudentInformationResponse> AddAsync(CreateStudentInformationRequest createStudentInformationRequest);
        Task<DeletedStudentInformationResponse> DeleteAsync(DeleteStudentInformationRequest deleteStudentInformationRequest);
        Task<UpdatedStudentInformationResponse> UpdateAsync(UpdateStudentInformationRequest updateStudentInformationRequest);
        Task<IPaginate<GetListStudentInformationResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdStudentInformationResponse> GetByIdAsync(Guid id);
    }

}
