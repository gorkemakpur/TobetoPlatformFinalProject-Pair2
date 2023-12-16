using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationDal _applicationDal;
        private readonly IMapper _mapper;

        public ApplicationManager(IApplicationDal applicationDal, IMapper mapper)
        {
            _applicationDal = applicationDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }


}
