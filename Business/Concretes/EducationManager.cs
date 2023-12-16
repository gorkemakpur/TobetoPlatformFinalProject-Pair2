using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class EducationManager : IEducationService
    {
        private readonly IEducationDal _educationDal;
        private readonly IMapper _mapper;

        public EducationManager(IEducationDal educationDal, IMapper mapper)
        {
            _educationDal = educationDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
