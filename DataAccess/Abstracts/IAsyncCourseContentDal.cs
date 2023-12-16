using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IAsyncCourseContentDal : IRepository<AsyncCourseContent, Guid>, IAsyncRepository<AsyncCourseContent, Guid>
    {

    }

}
