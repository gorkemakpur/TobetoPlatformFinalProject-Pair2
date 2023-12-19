using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class AsyncCourseManager : IAsyncCourseService
    {
        private readonly IAsyncCourseDal _asyncCourseDal;
        private readonly IMapper _mapper;

        public AsyncCourseManager(IAsyncCourseDal asyncCourseDal, IMapper mapper)
        {
            _asyncCourseDal = asyncCourseDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }
}
