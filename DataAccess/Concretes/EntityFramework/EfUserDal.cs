using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User, Guid, TobetoPlatformFinalProjectContext>, IUserDal
    {
        public EfUserDal(TobetoPlatformFinalProjectContext context) : base(context)
        {
        }

        public async Task<List<OperationClaim>> GetClaims(User user)
        {
                var result = from operationClaim in Context.OperationClaims
                             join userOperationClaim in Context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return await result.ToListAsync();
        }
    }
}
