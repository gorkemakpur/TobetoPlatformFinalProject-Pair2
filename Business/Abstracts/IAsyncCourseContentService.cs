using Business.Dtos.AsyncCourse.Request;
using Business.Dtos.AsyncCourse.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAsyncCourseContentService
    {
        Task<CreatedAsyncCourseResponse> AddAsync(CreateAsyncCourseRequest createAsyncCourseRequest);
        Task<DeletedAsyncCourseContentResponse> DeleteAsync(DeleteAsyncCourseContentRequest deleteAsyncCourseRequest);
        Task<UpdatedAsyncCourseContentResponse> UpdateAsync(UpdateAsyncCourseContentRequest updateAsyncCourseRequest);
        Task<IPaginate<GetListAsyncCourseContentResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdAsyncCourseContentResponse> GetByIdAsync(Guid id);
    }

}
