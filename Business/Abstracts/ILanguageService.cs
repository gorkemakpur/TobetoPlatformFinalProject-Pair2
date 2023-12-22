using Business.Dtos.Language.Request;
using Business.Dtos.Language.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ILanguageService
    {
        Task<CreatedLanguageResponse> AddAsync(CreateLanguageRequest createLanguageRequest);
        Task<DeletedLanguageResponse> DeleteAsync(DeleteLanguageRequest deleteLanguageRequest);
        Task<UpdatedLanguageResponse> UpdateAsync(UpdateLanguageRequest updateLanguageRequest);
        Task<IPaginate<GetListLanguageResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdLanguageResponse> GetByIdAsync(Guid id);
    }

}
