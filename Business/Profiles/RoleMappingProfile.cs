using AutoMapper;
using Business.Dtos.Role.Request;
using Business.Dtos.Role.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class RoleMappingProfile : Profile
{
    public RoleMappingProfile()
    {
        //create
        CreateMap<Role, CreateRoleRequest>().ReverseMap();
        CreateMap<Role, CreatedRoleResponse>().ReverseMap();
        CreateMap<CreatedRoleResponse, CreateRoleRequest>().ReverseMap();
        //get
        CreateMap<Role, GetListRoleResponse>().ReverseMap();
        CreateMap<Role, GetByIdRoleResponse>().ReverseMap();
        CreateMap<IPaginate<Role>, Paginate<GetListRoleResponse>>();
        //update
        CreateMap<Role, UpdateRoleRequest>().ReverseMap();
        CreateMap<Role, UpdatedRoleResponse>().ReverseMap();
        CreateMap<UpdatedRoleResponse, UpdateRoleRequest>().ReverseMap();
        //delete
        CreateMap<DeleteRoleRequest, DeletedRoleResponse>().ReverseMap();
    }

}
