using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ISyncCourseInstructorDal : IRepository<SyncCourseInstructor, Guid>, IAsyncRepository<SyncCourseInstructor, Guid>
    {

    }

}
