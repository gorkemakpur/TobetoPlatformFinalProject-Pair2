using Business.Dtos.Role.Request;
using Business.Dtos.Role.Response;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IRoleService
{
    Task<CreatedRoleResponse> AddAsync(CreateRoleRequest createRoleRequest);
    Task<DeletedRoleResponse> DeleteAsync(DeleteRoleRequest deleteRoleRequest);
    Task<UpdatedRoleResponse> UpdateAsync(UpdateRoleRequest updateRoleRequest);
    Task<IPaginate<GetListRoleResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetByIdRoleResponse> GetByIdAsync(Guid id);

}
