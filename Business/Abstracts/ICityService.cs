using Business.Dtos.City.Request;
using Business.Dtos.City.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ICityService
    {
        Task<CreatedCityResponse> AddAsync(CreateCityRequest createCityRequest);
        Task<DeletedCityResponse> DeleteAsync(DeleteCityRequest deleteCityRequest);
        Task<UpdatedCityResponse> UpdateAsync(UpdateCityRequest updateCityRequest);
        Task<IPaginate<GetListCityResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdCityResponse> GetByIdAsync(Guid id);

    }
}
