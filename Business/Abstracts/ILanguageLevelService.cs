using Business.Dtos.LanguageLevel.Request;
using Business.Dtos.LanguageLevel.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ILanguageLevelService
    {
        Task<CreatedLanguageLevelResponse> AddAsync(CreateLanguageLevelRequest createLanguageLevelRequest);
        Task<DeletedLanguageLevelResponse> DeleteAsync(DeleteLanguageLevelRequest deleteLanguageLevelRequest);
        Task<UpdatedLanguageLevelResponse> UpdateAsync(UpdateLanguageLevelRequest updateLanguageLevelRequest);
        Task<IPaginate<GetListLanguageLevelResponse>> GetListAsync();
        Task<GetByIdLanguageLevelResponse> GetByIdAsync(Guid id);
    }

}
