using Business.Dtos.AsyncCourseDepartment.Request;
using Business.Dtos.AsyncCourseDepartment.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAsyncCourseDepartmentService
    {
        Task<CreatedAsyncCourseDepartmentResponse> AddAsync(CreateAsyncCourseDepartmentRequest createAsyncCourseDepartmentRequest);
        Task<DeletedAsyncCourseDepartmentResponse> DeleteAsync(DeleteAsyncCourseDepartmentRequest deleteAsyncCourseDepartmentRequest);
        Task<UpdatedAsyncCourseDepartmentResponse> UpdateAsync(UpdateAsyncCourseDepartmentRequest updateAsyncCourseDepartmentRequest);
        Task<IPaginate<GetListAsyncCourseDepartmentResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdAsyncCourseDepartmentResponse> GetByIdAsync(Guid id);
    }

}
