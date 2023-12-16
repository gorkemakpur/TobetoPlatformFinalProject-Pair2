using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfLanguageTypeDal : EfRepositoryBase<LanguageType, Guid, TobetoPlatformFinalProjectContext>, ILanguageTypeDal
    {
        public EfLanguageTypeDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
