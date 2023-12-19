using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfDistrictDal : EfRepositoryBase<District, Guid, TobetoPlatformFinalProjectContext>, IDistrictDal
    {
        public EfDistrictDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }
}
