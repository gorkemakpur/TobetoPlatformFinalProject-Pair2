using Core.DataAccess.Repositories;
using Core.Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IOperationClaimDal : IRepository<OperationClaim, int>, IAsyncRepository<OperationClaim, int>
    {
    }
}
