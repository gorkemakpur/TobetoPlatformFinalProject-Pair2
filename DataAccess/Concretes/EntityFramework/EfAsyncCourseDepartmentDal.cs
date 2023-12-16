using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAsyncCourseDepartmentDal : EfRepositoryBase<AsyncCourseDepartment, Guid, TobetoPlatformFinalProjectContext>, IAsyncCourseDepartmentDal
    {
        public EfAsyncCourseDepartmentDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
