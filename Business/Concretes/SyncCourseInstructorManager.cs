using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    // Diğer Manager (Service) Sınıfları...
    public class SyncCourseInstructorManager : ISyncCourseInstructorService
    {
        private readonly ISyncCourseInstructorDal _syncCourseInstructorDal;
        private readonly IMapper _mapper;

        public SyncCourseInstructorManager(ISyncCourseInstructorDal syncCourseInstructorDal, IMapper mapper)
        {
            _syncCourseInstructorDal = syncCourseInstructorDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
