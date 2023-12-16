using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ISituationDal : IRepository<Situation, Guid>, IAsyncRepository<Situation, Guid>
    {

    }

}
