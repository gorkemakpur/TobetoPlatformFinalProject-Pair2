using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfEducationDal : EfRepositoryBase<Education, Guid, TobetoPlatformFinalProjectContext>, IEducationDal
    {
        public EfEducationDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
