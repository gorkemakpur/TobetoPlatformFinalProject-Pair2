using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ISyncCourseContentDal : IRepository<SyncCourseContent, Guid>, IAsyncRepository<SyncCourseContent, Guid>
    {

    }

}
