using Business.Dtos.User.Request;
using Business.Dtos.User.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IUserService
    {
        Task<CreatedUserResponse> AddAsync(CreateUserRequest createUserRequest);
        Task<DeletedUserResponse> DeleteAsync(DeleteUserRequest deleteUserRequest);
        Task<UpdatedUserResponse> UpdateAsync(UpdateUserRequest updateUserRequest);
        Task<IPaginate<GetListUserResponse>> GetListAsync(PageRequest pageRequest);
        Task<GetByIdUserResponse> GetByIdAsync(Guid id);
    }
}
