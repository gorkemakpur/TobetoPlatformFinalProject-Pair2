using AutoMapper;
using Business.Abstracts;
using Business.Dtos.LanguageType.Request;
using Business.Dtos.LanguageType.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class LanguageTypeManager : ILanguageTypeService
{
    private readonly ILanguageTypeDal _languageTypeDal;
    private readonly IMapper _mapper;

    public LanguageTypeManager(ILanguageTypeDal languageTypeDal, IMapper mapper)
    {
        _languageTypeDal = languageTypeDal;
        _mapper = mapper;
    }

    public async Task<CreatedLanguageTypeResponse> AddAsync(CreateLanguageTypeRequest createLanguageTypeRequest)
    {
        LanguageType addLanguageType = _mapper.Map<LanguageType>(createLanguageTypeRequest);

        LanguageType createdLanguageType = await _languageTypeDal.AddAsync(addLanguageType);

        CreatedLanguageTypeResponse createdLanguageTypeResponse = _mapper.Map<CreatedLanguageTypeResponse>(createdLanguageType);
        return createdLanguageTypeResponse;
    }

    public async Task<DeletedLanguageTypeResponse> DeleteAsync(DeleteLanguageTypeRequest deleteLanguageTypeRequest)
    {
        LanguageType removeLanguageType = await _languageTypeDal.GetAsync(predicate: lt => lt.Id == deleteLanguageTypeRequest.Id);

        await _languageTypeDal.DeleteAsync(removeLanguageType);

        DeletedLanguageTypeResponse deletedLanguageTypeResponse = _mapper.Map<DeletedLanguageTypeResponse>(deleteLanguageTypeRequest);
        return deletedLanguageTypeResponse;
    }

    public async Task<GetByIdLanguageTypeResponse> GetByIdAsync(Guid id)
    {
        LanguageType result = await _languageTypeDal.GetAsync(predicate: lt => lt.Id == id);
        GetByIdLanguageTypeResponse data = _mapper.Map<GetByIdLanguageTypeResponse>(result);
        return data;
    }

    public async Task<IPaginate<GetListLanguageTypeResponse>> GetListAsync(PageRequest pageRequest)
    {
        var data = await _languageTypeDal.GetListAsync(
            index: 0,//pageRequest.PageIndex,
            size: 10 //pageRequest.PageSize
            );

        var result = _mapper.Map<Paginate<GetListLanguageTypeResponse>>(data);
        return result;
    }

    public async Task<UpdatedLanguageTypeResponse> UpdateAsync(UpdateLanguageTypeRequest updateLanguageTypeRequest)
    {
        LanguageType updateLanguageType = await _languageTypeDal.GetAsync(predicate: lt => lt.Id == updateLanguageTypeRequest.Id);

        _mapper.Map(updateLanguageTypeRequest, updateLanguageType);

        LanguageType updatedLanguageType = await _languageTypeDal.UpdateAsync(updateLanguageType);

        UpdatedLanguageTypeResponse updatedLanguageTypeResponse = _mapper.Map<UpdatedLanguageTypeResponse>(updatedLanguageType);

        return updatedLanguageTypeResponse;
    }
}
