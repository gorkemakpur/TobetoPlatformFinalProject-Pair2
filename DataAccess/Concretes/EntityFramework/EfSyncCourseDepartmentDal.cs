using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSyncCourseDepartmentDal : EfRepositoryBase<SyncCourseDepartment, Guid, TobetoPlatformFinalProjectContext>, ISyncCourseDepartmentDal
    {
        public EfSyncCourseDepartmentDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
