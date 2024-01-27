using Business.Dtos.UserOperationClaim.Request;
using Business.Dtos.UserOperationClaim.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IUserOperationClaimService
    {
        Task<CreatedUserOperationClaimResponse> AddAsync(CreateUserOperationClaimRequest createUserOperationClaimRequest);
        Task<DeletedUserOperationClaimResponse> DeleteAsync(DeleteUserOperationClaimRequest deleteUserOperationClaimRequest);
        Task<UpdatedUserOperationClaimResponse> UpdateAsync(UpdateUserOperationClaimRequest updateUserOperationClaimRequest);
        Task<IPaginate<GetListUserOperationClaimResponse>> GetListAsync();
        Task<GetByIdUserOperationClaimResponse> GetByIdAsync(int id);
    }


}
