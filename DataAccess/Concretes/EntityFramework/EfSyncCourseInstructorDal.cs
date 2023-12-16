using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSyncCourseInstructorDal : EfRepositoryBase<SyncCourseInstructor, Guid, TobetoPlatformFinalProjectContext>, ISyncCourseInstructorDal
    {
        public EfSyncCourseInstructorDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
