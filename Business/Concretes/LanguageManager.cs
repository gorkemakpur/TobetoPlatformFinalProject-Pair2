using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class LanguageManager : ILanguageService
    {
        private readonly ILanguageDal _languageDal;
        private readonly IMapper _mapper;

        public LanguageManager(ILanguageDal languageDal, IMapper mapper)
        {
            _languageDal = languageDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
