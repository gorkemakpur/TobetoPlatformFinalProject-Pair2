using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class SurveyManager : ISurveyService
    {
        private readonly ISurveyDal _surveyDal;
        private readonly IMapper _mapper;

        public SurveyManager(ISurveyDal surveyDal, IMapper mapper)
        {
            _surveyDal = surveyDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
