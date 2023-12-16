using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class SituationManager : ISituationService
    {
        private readonly ISituationDal _situationDal;
        private readonly IMapper _mapper;

        public SituationManager(ISituationDal situationDal, IMapper mapper)
        {
            _situationDal = situationDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
