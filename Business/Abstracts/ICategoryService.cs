using Business.Dtos.Category.Request;
using Business.Dtos.Category.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest);
        Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest);
        Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest);
        Task<IPaginate<GetListCategoryResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdCategoryResponse> GetByIdAsync(Guid id);
    }

}
