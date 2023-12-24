using AutoMapper;
using Business.Dtos.Department.Request;
using Business.Dtos.Department.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class DepartmentMappingProfile : Profile
{
    public DepartmentMappingProfile()
    {
        //create
        CreateMap<Department, CreateDepartmentRequest>().ReverseMap();
        CreateMap<Department, CreatedDepartmentResponse>().ReverseMap();
        CreateMap<CreatedDepartmentResponse, CreateDepartmentRequest>().ReverseMap();
        //list
        CreateMap<Department, GetListDepartmentResponse>().ReverseMap();
        CreateMap<Department, GetByIdDepartmentResponse>().ReverseMap();
        CreateMap<IPaginate<Department>, Paginate<GetListDepartmentResponse>>();
        //delete
        CreateMap<DeleteDepartmentRequest, DeletedDepartmentResponse>().ReverseMap();
        //update
        CreateMap<Department, UpdateDepartmentRequest>().ReverseMap();
        CreateMap<UpdateDepartmentRequest, UpdatedDepartmentResponse>().ReverseMap();
    }
}