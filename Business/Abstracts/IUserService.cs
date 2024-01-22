using Business.Dtos.User.Request;
using Business.Dtos.User.Response;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;

namespace Business.Abstracts
{
    public interface IUserService
    {   //14
        Task<GetUserResponse> GetAsync(Guid id);
        Task<List<OperationClaim>> GetClaims(User user);
        Task<GetUserResponse> Add(User user);
        Task<GetUserResponse> GetByMailAsync(string email);
        //--
        Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest);
        
        Task<DeletedUserResponse> DeleteAsync(DeleteUserRequest deleteUserRequest);
        Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest);
        Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdUserResponse> GetByIdAsync(Guid id);
    }
}
