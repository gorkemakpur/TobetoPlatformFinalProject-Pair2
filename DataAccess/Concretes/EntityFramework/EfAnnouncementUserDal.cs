using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAnnouncementUserDal : EfRepositoryBase<AnnouncementUser, Guid, TobetoPlatformFinalProjectContext>, IAnnouncementUserDal
    {
        public EfAnnouncementUserDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }
}
