using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class AsyncCourseDepartmentManager : IAsyncCourseDepartmentService
    {
        private readonly IAsyncCourseDepartmentDal _asyncCourseDepartmentDal;
        private readonly IMapper _mapper;

        public AsyncCourseDepartmentManager(IAsyncCourseDepartmentDal asyncCourseDepartmentDal, IMapper mapper)
        {
            _asyncCourseDepartmentDal = asyncCourseDepartmentDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
