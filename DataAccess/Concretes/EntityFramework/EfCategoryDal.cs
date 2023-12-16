using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category, Guid, TobetoPlatformFinalProjectContext>, ICategoryDal
    {
        public EfCategoryDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
