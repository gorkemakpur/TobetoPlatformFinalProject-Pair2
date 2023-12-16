using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSituationDal : EfRepositoryBase<Situation, Guid, TobetoPlatformFinalProjectContext>, ISituationDal
    {
        public EfSituationDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
