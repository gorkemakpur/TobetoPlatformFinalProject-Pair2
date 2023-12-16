using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfStudentDal : EfRepositoryBase<Student, Guid, TobetoPlatformFinalProjectContext>, IStudentDal
    {
        public EfStudentDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
