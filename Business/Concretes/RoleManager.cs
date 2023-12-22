using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Role.Request;
using Business.Dtos.Role.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class RoleManager : IRoleService
{
    private readonly IRoleDal _roleDal;
    private readonly IMapper _mapper;

    public RoleManager(IRoleDal roleDal, IMapper mapper)
    {
        _roleDal = roleDal;
        _mapper = mapper;
    }

    public async Task<CreatedRoleResponse> AddAsync(CreateRoleRequest createRoleRequest)
    {
        Role addRole = _mapper.Map<Role>(createRoleRequest);

        Role createdRole = await _roleDal.AddAsync(addRole);

        CreatedRoleResponse createdRoleResponse = _mapper.Map<CreatedRoleResponse>(createdRole);
        return createdRoleResponse;
    }

    public async Task<DeletedRoleResponse> DeleteAsync(DeleteRoleRequest deleteRoleRequest)
    {
        Role removeRole = await _roleDal.GetAsync(predicate: r => r.Id == deleteRoleRequest.Id);

        await _roleDal.DeleteAsync(removeRole);

        DeletedRoleResponse deletedRoleResponse = _mapper.Map<DeletedRoleResponse>(deleteRoleRequest);
        return deletedRoleResponse;
    }

    public async Task<GetByIdRoleResponse> GetByIdAsync(Guid id)
    {
        Role result = await _roleDal.GetAsync(r => r.Id == id);
        GetByIdRoleResponse data = _mapper.Map<GetByIdRoleResponse>(result);
        return data;
    }

    public async Task<IPaginate<GetListRoleResponse>> GetListAsync(PageRequest pageRequest)
    {
        var data = await _roleDal.GetListAsync(
            index: 0,//pageRequest.PageIndex,
            size: 10 //pageRequest.PageSize
            );

        var result = _mapper.Map<Paginate<GetListRoleResponse>>(data);
        return result;
    }

    public async Task<UpdatedRoleResponse> UpdateAsync(UpdateRoleRequest updateRoleRequest)
    {
        Role updateRole = await _roleDal.GetAsync(r => r.Id == updateRoleRequest.Id);

        _mapper.Map(updateRoleRequest, updateRole);

        Role updatedRole = await _roleDal.UpdateAsync(updateRole);

        UpdatedRoleResponse updatedRoleResponse = _mapper.Map<UpdatedRoleResponse>(updatedRole);

        return updatedRoleResponse;
    }
}
