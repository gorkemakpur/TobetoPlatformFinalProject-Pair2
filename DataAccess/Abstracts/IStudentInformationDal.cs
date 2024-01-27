using Core.DataAccess.Repositories;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
    public interface IStudentInformationDal : IRepository<StudentInformation, Guid>, IAsyncRepository<StudentInformation, Guid>
    {

    }


}
