using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class CompetenceManager : ICompetenceService
    {
        private readonly ICompetenceDal _competenceDal;
        private readonly IMapper _mapper;

        public CompetenceManager(ICompetenceDal competenceDal, IMapper mapper)
        {
            _competenceDal = competenceDal;
            _mapper = mapper;
        }  

        // İlgili metotlar
    }

}
