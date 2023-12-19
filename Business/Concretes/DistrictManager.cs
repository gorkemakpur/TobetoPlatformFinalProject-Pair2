using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class DistrictManager : IDistrictService
    {
        private readonly IDistrictDal _districtDal;
        private readonly IMapper _mapper;

        public DistrictManager(IDistrictDal districtDal, IMapper mapper)
        {
            _districtDal = districtDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }
}
