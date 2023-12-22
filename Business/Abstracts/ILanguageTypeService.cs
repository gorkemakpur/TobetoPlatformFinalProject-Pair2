using Business.Dtos.LanguageType.Request;
using Business.Dtos.LanguageType.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ILanguageTypeService
    {
        Task<CreatedLanguageTypeResponse> AddAsync(CreateLanguageTypeRequest createLanguageTypeRequest);
        Task<DeletedLanguageTypeResponse> DeleteAsync(DeleteLanguageTypeRequest deleteLanguageTypeRequest);
        Task<UpdatedLanguageTypeResponse> UpdateAsync(UpdateLanguageTypeRequest updateLanguageTypeRequest);
        Task<IPaginate<GetListLanguageTypeResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdLanguageTypeResponse> GetByIdAsync(Guid id);
    }

}
