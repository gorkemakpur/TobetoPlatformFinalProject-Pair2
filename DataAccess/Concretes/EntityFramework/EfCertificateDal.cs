using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCertificateDal : EfRepositoryBase<Certificate, Guid, TobetoPlatformFinalProjectContext>, ICertificateDal
    {
        public EfCertificateDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
