using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfDepartmentDal : EfRepositoryBase<Department, Guid, TobetoPlatformFinalProjectContext>, IDepartmentDal
    {
        public EfDepartmentDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
