using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IRoleDal : IRepository<Role, Guid>, IAsyncRepository<Role, Guid>
    {

    }


    //AnnouncementUser
    //City
    //District
    //User
    //    Role


}
