using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface ILanguageTypeDal : IRepository<LanguageType, Guid>, IAsyncRepository<LanguageType, Guid>
    {

    }

}
