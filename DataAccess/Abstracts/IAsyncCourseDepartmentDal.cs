using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IAsyncCourseDepartmentDal : IRepository<AsyncCourseDepartment, Guid>, IAsyncRepository<AsyncCourseDepartment, Guid>
    {

    }

}
