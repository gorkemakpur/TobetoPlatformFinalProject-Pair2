using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfRoleDal : EfRepositoryBase<Role, Guid, TobetoPlatformFinalProjectContext>, IRoleDal
    {
        public EfRoleDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }
}
