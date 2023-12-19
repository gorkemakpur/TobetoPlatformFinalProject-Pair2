using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCityDal : EfRepositoryBase<City, Guid, TobetoPlatformFinalProjectContext>, ICityDal
    {
        public EfCityDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }
}
