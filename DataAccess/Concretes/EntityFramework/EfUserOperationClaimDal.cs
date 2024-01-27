using Core.DataAccess.Repositories;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using DataAccess.Context;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserOperationClaimDal : EfRepositoryBase<UserOperationClaim, int, TobetoPlatformFinalProjectContext>, IUserOperationClaimDal
    {
        public EfUserOperationClaimDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
