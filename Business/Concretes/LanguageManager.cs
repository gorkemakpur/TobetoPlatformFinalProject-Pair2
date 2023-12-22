using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Language.Request;
using Business.Dtos.Language.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class LanguageManager : ILanguageService
{
    private readonly ILanguageDal _languageDal;
    private readonly IMapper _mapper;

    public LanguageManager(ILanguageDal languageDal, IMapper mapper)
    {
        _languageDal = languageDal;
        _mapper = mapper;
    }

    public async Task<CreatedLanguageResponse> AddAsync(CreateLanguageRequest createLanguageRequest)
    {
        Language addLanguage = _mapper.Map<Language>(createLanguageRequest);

        Language createdLanguage = await _languageDal.AddAsync(addLanguage);

        CreatedLanguageResponse createdLanguageResponse = _mapper.Map<CreatedLanguageResponse>(createdLanguage);
        return createdLanguageResponse;
    }

    public async Task<DeletedLanguageResponse> DeleteAsync(DeleteLanguageRequest deleteLanguageRequest)
    {
        Language removeLanguage = await _languageDal.GetAsync(predicate: l => l.Id == deleteLanguageRequest.Id);

        await _languageDal.DeleteAsync(removeLanguage);

        DeletedLanguageResponse deletedLanguageResponse = _mapper.Map<DeletedLanguageResponse>(deleteLanguageRequest);
        return deletedLanguageResponse;
    }

    public async Task<GetByIdLanguageResponse> GetByIdAsync(Guid id)
    {
        Language result = await _languageDal.GetAsync(l => l.Id == id);
        GetByIdLanguageResponse data = _mapper.Map<GetByIdLanguageResponse>(result);
        return data;
    }

    public async Task<IPaginate<GetListLanguageResponse>> GetListAsync(PageRequest pageRequest)
    {
        var data = await _languageDal.GetListAsync(
            index: 0,//pageRequest.PageIndex,
            size: 10 //pageRequest.PageSize
            );

        var result = _mapper.Map<Paginate<GetListLanguageResponse>>(data);
        return result;
    }

    public async Task<UpdatedLanguageResponse> UpdateAsync(UpdateLanguageRequest updateLanguageRequest)
    {
        Language updateLanguage = await _languageDal.GetAsync(l => l.Id == updateLanguageRequest.Id);

        _mapper.Map(updateLanguageRequest, updateLanguage);

        Language updatedLanguage = await _languageDal.UpdateAsync(updateLanguage);

        UpdatedLanguageResponse updatedLanguageResponse = _mapper.Map<UpdatedLanguageResponse>(updatedLanguage);

        return updatedLanguageResponse;
    }
}
