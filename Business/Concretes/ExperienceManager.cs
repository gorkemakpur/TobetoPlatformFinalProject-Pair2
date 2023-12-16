using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;
        private readonly IMapper _mapper;

        public ExperienceManager(IExperienceDal experienceDal, IMapper mapper)
        {
            _experienceDal = experienceDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
