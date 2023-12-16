using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class SyncCourseDepartmentManager : ISyncCourseDepartmentService
    {
        private readonly ISyncCourseDepartmentDal _syncCourseDepartmentDal;
        private readonly IMapper _mapper;

        public SyncCourseDepartmentManager(ISyncCourseDepartmentDal syncCourseDepartmentDal, IMapper mapper)
        {
            _syncCourseDepartmentDal = syncCourseDepartmentDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
