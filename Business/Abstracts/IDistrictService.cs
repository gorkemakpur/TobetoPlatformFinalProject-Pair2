using Business.Dtos.District.Request;
using Business.Dtos.District.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IDistrictService
    {
        Task<CreatedDistrictResponse> AddAsync(CreateDistrictRequest createDistrictRequest);
        Task<DeletedDistrictResponse> DeleteAsync(DeleteDistrictRequest deleteDistrictRequest);
        Task<UpdatedDistrictResponse> UpdateAsync(UpdateDistrictRequest updateDistrictRequest);
        Task<IPaginate<GetListDistrictResponse>> GetListAsync();
        Task<GetByIdDistrictResponse> GetByIdAsync(Guid id);
    }
}
