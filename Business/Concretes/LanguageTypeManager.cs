using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class LanguageTypeManager : ILanguageTypeService
    {
        private readonly ILanguageTypeDal _languageTypeDal;
        private readonly IMapper _mapper;

        public LanguageTypeManager(ILanguageTypeDal languageTypeDal, IMapper mapper)
        {
            _languageTypeDal = languageTypeDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }


}
