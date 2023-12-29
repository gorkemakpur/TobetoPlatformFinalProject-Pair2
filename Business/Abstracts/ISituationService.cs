using Business.Dtos.Situation.Request;
using Business.Dtos.Situation.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface ISituationService
    {
        Task<CreatedSituationResponse> AddAsync(CreateSituationRequest createSituationRequest);
        Task<DeletedSituationResponse> DeleteAsync(DeleteSituationRequest deleteSituationRequest);
        Task<UpdatedSituationResponse> UpdateAsync(UpdateSituationRequest updateSituationRequest);
        Task<IPaginate<GetListSituationResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdSituationResponse> GetByIdAsync(Guid id);
    }

}
