using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfUserDal : EfRepositoryBase<User, Guid, TobetoPlatformFinalProjectContext>, IUserDal
    {
        public EfUserDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }
}
