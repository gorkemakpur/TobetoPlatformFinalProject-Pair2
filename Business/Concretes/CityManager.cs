using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class CityManager : ICityService
    {
        private readonly ICityDal _cityDal;
        private readonly IMapper _mapper;

        public CityManager(ICityDal cityDal, IMapper mapper)
        {
            _cityDal = cityDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }
}
