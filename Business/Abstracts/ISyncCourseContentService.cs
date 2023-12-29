using Business.Dtos.SyncCourseContent.Request;
using Business.Dtos.SyncCourseContent.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISyncCourseContentService
    {
        Task<CreatedSyncCourseContentResponse> AddAsync(CreateSyncCourseContentRequest createSyncCourseContentRequest);
        Task<DeletedSyncCourseContentResponse> DeleteAsync(DeleteSyncCourseContentRequest deleteSyncCourseContentRequest);
        Task<UpdatedSyncCourseContentResponse> UpdateAsync(UpdateSyncCourseContentRequest updateSyncCourseContentRequest);
        Task<IPaginate<GetListSyncCourseContentResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdSyncCourseContentResponse> GetByIdAsync(Guid id);

    }
}
