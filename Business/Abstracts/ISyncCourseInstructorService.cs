using Business.Dtos.SyncCourseInstructor.Request;
using Business.Dtos.SyncCourseInstructor.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISyncCourseInstructorService
    {
        Task<CreatedSyncCourseInstructorResponse> AddAsync(CreateSyncCourseInstructorRequest createSyncCourseInstructorRequest);
        Task<DeletedSyncCourseInstructorResponse> DeleteAsync(DeleteSyncCourseInstructorRequest deleteSyncCourseInstructorRequest);
        Task<UpdatedSyncCourseInstructorResponse> UpdateAsync(UpdateSyncCourseInstructorRequest updateSyncCourseInstructorRequest);
        Task<IPaginate<GetListSyncCourseInstructorResponse>> GetListAsync();
        Task<GetByIdSyncCourseInstructorResponse> GetByIdAsync(Guid id);
    }

}
