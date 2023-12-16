using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfInstructorDal : EfRepositoryBase<Instructor, Guid, TobetoPlatformFinalProjectContext>, IInstructorDal
    {
        public EfInstructorDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
