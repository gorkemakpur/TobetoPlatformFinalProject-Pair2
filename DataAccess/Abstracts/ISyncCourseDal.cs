using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ISyncCourseDal : IRepository<SyncCourse, Guid>, IAsyncRepository<SyncCourse, Guid>
    {

    }

}
