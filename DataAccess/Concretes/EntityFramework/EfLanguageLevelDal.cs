using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfLanguageLevelDal : EfRepositoryBase<LanguageLevel, Guid, TobetoPlatformFinalProjectContext>, ILanguageLevelDal
    {
        public EfLanguageLevelDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
