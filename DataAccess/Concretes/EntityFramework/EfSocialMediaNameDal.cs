using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSocialMediaNameDal : EfRepositoryBase<SocialMediaName, Guid, TobetoPlatformFinalProjectContext>, ISocialMediaNameDal
    {
        public EfSocialMediaNameDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
