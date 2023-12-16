using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IDepartmentDal : IRepository<Department, Guid>, IAsyncRepository<Department, Guid>
    {

    }

}
