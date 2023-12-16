using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfApplicationDal : EfRepositoryBase<Application, Guid, TobetoPlatformFinalProjectContext>, IApplicationDal
    {
        public EfApplicationDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
