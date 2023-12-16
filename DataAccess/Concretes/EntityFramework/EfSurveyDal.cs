using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Context;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfSurveyDal : EfRepositoryBase<Survey, Guid, TobetoPlatformFinalProjectContext>, ISurveyDal
    {
        public EfSurveyDal(TobetoPlatformFinalProjectContext context) : base(context)
        {

        }
    }


}
