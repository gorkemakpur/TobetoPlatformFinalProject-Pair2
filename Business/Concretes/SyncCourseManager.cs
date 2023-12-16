using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class SyncCourseManager : ISyncCourseService
    {
        private readonly ISyncCourseDal _syncCourseDal;
        private readonly IMapper _mapper;

        public SyncCourseManager(ISyncCourseDal syncCourseDal, IMapper mapper)
        {
            _syncCourseDal = syncCourseDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
