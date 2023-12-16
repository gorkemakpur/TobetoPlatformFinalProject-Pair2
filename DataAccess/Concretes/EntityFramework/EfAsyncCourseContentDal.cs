using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAsyncCourseContentDal : EfRepositoryBase<AsyncCourseContent, Guid, TobetoPlatformFinalProjectContext>, IAsyncCourseContentDal
    {
        public EfAsyncCourseContentDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
