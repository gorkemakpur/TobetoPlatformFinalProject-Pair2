using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSocialMediaDal : EfRepositoryBase<SocialMedia, Guid, TobetoPlatformFinalProjectContext>, ISocialMediaDal
    {
        public EfSocialMediaDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
