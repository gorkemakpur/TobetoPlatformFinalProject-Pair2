using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfAnnouncementDal : EfRepositoryBase<Announcement, Guid, TobetoPlatformFinalProjectContext>, IAnnouncementDal
    {
        public EfAnnouncementDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }
}
