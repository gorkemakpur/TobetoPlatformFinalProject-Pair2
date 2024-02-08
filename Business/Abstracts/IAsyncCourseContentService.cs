using Business.Dtos.AsyncCourse.Request;
using Business.Dtos.AsyncCourse.Response;
using Business.Dtos.AsyncCourseContent.Request;
using Business.Dtos.AsyncCourseContent.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IAsyncCourseContentService
    {
        Task<CreatedAsyncCourseContentResponse> AddAsync(CreateAsyncCourseContentRequest createAsyncCourseContentRequest);
        Task<DeletedAsyncCourseContentResponse> DeleteAsync(DeleteAsyncCourseContentRequest deleteAsyncCourseContentRequest);
        Task<UpdatedAsyncCourseContentResponse> UpdateAsync(UpdateAsyncCourseContentRequest updateAsyncCourseContentRequest);
        Task<IPaginate<GetListAsyncCourseContentResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdAsyncCourseContentResponse> GetByIdAsync(Guid id);

        Task<IPaginate<GetListAsyncCourseContentResponse>> GetByAsynCourseId(Guid id);
    }


}
