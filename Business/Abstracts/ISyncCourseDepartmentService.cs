using Business.Dtos.SyncCourseDepartment.Request;
using Business.Dtos.SyncCourseDepartment.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISyncCourseDepartmentService
    {
        Task<CreatedSyncCourseDepartmentResponse> AddAsync(CreateSyncCourseDepartmentRequest createSyncCourseDepartmentRequest);
        Task<DeletedSyncCourseDepartmentResponse> DeleteAsync(DeleteSyncCourseDepartmentRequest deleteSyncCourseDepartmentRequest);
        Task<UpdatedSyncCourseDepartmentResponse> UpdateAsync(UpdateSyncCourseDepartmentRequest updateSyncCourseDepartmentRequest);
        Task<IPaginate<GetListSyncCourseDepartmentResponse>> GetListAsync();
        Task<GetByIdSyncCourseDepartmentResponse> GetByIdAsync(Guid id);
    }

}
