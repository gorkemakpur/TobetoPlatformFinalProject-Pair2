using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class AsyncCourseContentManager : IAsyncCourseContentService
    {
        private readonly IAsyncCourseContentDal _asyncCourseContentDal;
        private readonly IMapper _mapper;

        public AsyncCourseContentManager(IAsyncCourseContentDal asyncCourseContentDal, IMapper mapper)
        {
            _asyncCourseContentDal = asyncCourseContentDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
