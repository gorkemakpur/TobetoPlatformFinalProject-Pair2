using Core.DataAccess.Repositories;
using Core.Entities.Concrete;
using DataAccess.Abstracts;
using DataAccess.Context;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfOperationClaimDal : EfRepositoryBase<OperationClaim, int, TobetoPlatformFinalProjectContext>, IOperationClaimDal
    {
        public EfOperationClaimDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
