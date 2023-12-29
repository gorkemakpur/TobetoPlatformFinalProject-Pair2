using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AsyncCourse.Request;
using Business.Dtos.AsyncCourse.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAsyncCourseService
    {
        Task<CreatedAsyncCourseResponse> AddAsync(CreateAsyncCourseRequest createAsyncCourseRequest);
        Task<DeletedAsyncCourseResponse> DeleteAsync(DeleteAsyncCourseRequest deleteAsyncCourseRequest);
        Task<UpdatedAsyncCourseResponse> UpdateAsync(UpdateAsyncCourseRequest updateAsyncCourseRequest);
        Task<IPaginate<GetListAsyncCourseResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdAsyncCourseResponse> GetByIdAsync(Guid id);
    }

}
