using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ISyncCourseDepartmentDal : IRepository<SyncCourseDepartment, Guid>, IAsyncRepository<SyncCourseDepartment, Guid>
    {

    }

}
