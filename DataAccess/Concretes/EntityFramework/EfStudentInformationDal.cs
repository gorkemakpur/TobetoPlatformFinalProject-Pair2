using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfStudentInformationDal : EfRepositoryBase<StudentInformation, Guid, TobetoPlatformFinalProjectContext>, IStudentInformationDal
    {
        public EfStudentInformationDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
