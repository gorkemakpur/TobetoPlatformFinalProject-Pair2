using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCompetenceDal : EfRepositoryBase<Competence, Guid, TobetoPlatformFinalProjectContext>, ICompetenceDal
    {
        public EfCompetenceDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
