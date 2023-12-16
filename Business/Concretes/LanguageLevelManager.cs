using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class LanguageLevelManager : ILanguageLevelService
    {
        private readonly ILanguageLevelDal _languageLevelDal;
        private readonly IMapper _mapper;

        public LanguageLevelManager(ILanguageLevelDal languageLevelDal, IMapper mapper)
        {
            _languageLevelDal = languageLevelDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
