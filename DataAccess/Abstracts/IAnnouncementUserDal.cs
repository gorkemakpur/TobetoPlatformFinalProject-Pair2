using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IAnnouncementUserDal : IRepository<AnnouncementUser, Guid>, IAsyncRepository<AnnouncementUser, Guid>
    {

    }


    //AnnouncementUser
    //City
    //District
    //User
    //    Role


}
