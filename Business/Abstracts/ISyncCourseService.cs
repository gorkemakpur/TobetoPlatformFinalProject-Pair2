using Business.Dtos.SyncCourse.Request;
using Business.Dtos.SyncCourse.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISyncCourseService
    {
        Task<CreatedSyncCourseResponse> AddAsync(CreateSyncCourseRequest createSyncCourseRequest);
        Task<DeletedSyncCourseResponse> DeleteAsync(DeleteSyncCourseRequest deleteSyncCourseRequest);
        Task<UpdatedSyncCourseResponse> UpdateAsync(UpdateSyncCourseRequest updateSyncCourseRequest);
        Task<IPaginate<GetListSyncCourseResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdSyncCourseResponse> GetByIdAsync(Guid id);
    }
}
