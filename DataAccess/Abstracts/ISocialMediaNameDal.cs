using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ISocialMediaNameDal : IRepository<SocialMediaName, Guid>, IAsyncRepository<SocialMediaName, Guid>
    {

    }

}
