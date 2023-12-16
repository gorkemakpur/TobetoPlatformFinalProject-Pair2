using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSyncCourseContentDal : EfRepositoryBase<SyncCourseContent, Guid, TobetoPlatformFinalProjectContext>, ISyncCourseContentDal
    {
        public EfSyncCourseContentDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
