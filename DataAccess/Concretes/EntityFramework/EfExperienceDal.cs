using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfExperienceDal : EfRepositoryBase<Experience, Guid, TobetoPlatformFinalProjectContext>, IExperienceDal
    {
        public EfExperienceDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
