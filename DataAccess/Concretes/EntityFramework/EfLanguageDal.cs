using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfLanguageDal : EfRepositoryBase<Language, Guid, TobetoPlatformFinalProjectContext>, ILanguageDal
    {
        public EfLanguageDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
