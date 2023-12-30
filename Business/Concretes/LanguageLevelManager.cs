using AutoMapper;
using Business.Abstracts;
using Business.Dtos.LanguageLevel.Request;
using Business.Dtos.LanguageLevel.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

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

        public async Task<CreatedLanguageLevelResponse> AddAsync(CreateLanguageLevelRequest createLanguageLevelRequest)
        {
            var languageLevel = _mapper.Map<LanguageLevel>(createLanguageLevelRequest);
            var result = await _languageLevelDal.AddAsync(languageLevel);
            return _mapper.Map<CreatedLanguageLevelResponse>(result);
        }

        public async Task<DeletedLanguageLevelResponse> DeleteAsync(DeleteLanguageLevelRequest deleteLanguageLevelRequest)
        {
            var languageLevel = await _languageLevelDal.GetAsync(x => x.Id == deleteLanguageLevelRequest.Id);
            var result = await _languageLevelDal.DeleteAsync(languageLevel);
            return _mapper.Map<DeletedLanguageLevelResponse>(result);
        }

        public async Task<UpdatedLanguageLevelResponse> UpdateAsync(UpdateLanguageLevelRequest updateLanguageLevelRequest)
        {
            var languageLevel = await _languageLevelDal.GetAsync(x => x.Id == updateLanguageLevelRequest.Id);
            _mapper.Map(updateLanguageLevelRequest, languageLevel);
            var result = await _languageLevelDal.UpdateAsync(languageLevel);
            return _mapper.Map<UpdatedLanguageLevelResponse>(result);
        }

        public async Task<IPaginate<GetListLanguageLevelResponse>> GetListAsync()
        {
            var languageLevels = await _languageLevelDal.GetListAsync();
            return _mapper.Map<Paginate<GetListLanguageLevelResponse>>(languageLevels);
        }
        
        public async Task<GetByIdLanguageLevelResponse> GetByIdAsync(Guid id)
        {
            var languageLevel = await _languageLevelDal.GetAsync(x=>x.Id == id);
            return _mapper.Map<GetByIdLanguageLevelResponse>(languageLevel);
        }
    }

}
