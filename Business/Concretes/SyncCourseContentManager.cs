using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class SyncCourseContentManager : ISyncCourseContentService
    {
        private readonly ISyncCourseContentDal _syncCourseContentDal;
        private readonly IMapper _mapper;

        public SyncCourseContentManager(ISyncCourseContentDal syncCourseContentDal, IMapper mapper)
        {
            _syncCourseContentDal = syncCourseContentDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
