using Business.Dtos.Department.Request;
using Business.Dtos.Department.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IDepartmentService
    {
        Task<CreatedDepartmentResponse> AddAsync(CreateDepartmentRequest createDepartmentRequest);
        Task<DeletedDepartmentResponse> DeleteAsync(DeleteDepartmentRequest deleteDepartmentRequest);
        Task<UpdatedDepartmentResponse> UpdateAsync(UpdateDepartmentRequest updateDepartmentRequest);
        Task<IPaginate<GetListDepartmentResponse>> GetListAsync();
        Task<GetByIdDepartmentResponse> GetByIdAsync(Guid id);
    }

}
