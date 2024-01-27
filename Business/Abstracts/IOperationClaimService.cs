using Business.Dtos.OperationClaim.Request;
using Business.Dtos.OperationClaim.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IOperationClaimService
    {
        Task<CreatedOperationClaimResponse> AddAsync(CreateOperationClaimRequest createOperationClaimRequest);
        Task<DeletedOperationClaimResponse> DeleteAsync(DeleteOperationClaimRequest deleteOperationClaimRequest);
        Task<UpdatedOperationClaimResponse> UpdateAsync(UpdateOperationClaimRequest updateOperationClaimRequest);
        Task<IPaginate<GetListOperationClaimResponse>> GetListAsync();
        Task<GetByIdOperationClaimResponse> GetByIdAsync(int id);
    }

}
