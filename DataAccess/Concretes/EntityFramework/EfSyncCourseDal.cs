using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSyncCourseDal : EfRepositoryBase<SyncCourse, Guid, TobetoPlatformFinalProjectContext>, ISyncCourseDal
    {
        public EfSyncCourseDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
