using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAsyncCourseDal : EfRepositoryBase<AsyncCourse, Guid, TobetoPlatformFinalProjectContext>, IAsyncCourseDal
    {
        public EfAsyncCourseDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
