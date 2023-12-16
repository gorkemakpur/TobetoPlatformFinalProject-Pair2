using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAnnouncementTypeDal : EfRepositoryBase<AnnouncementType, Guid, TobetoPlatformFinalProjectContext>, IAnnouncementTypeDal
    {
        public EfAnnouncementTypeDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
