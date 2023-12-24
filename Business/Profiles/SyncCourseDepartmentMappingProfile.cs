using AutoMapper;
using Business.Dtos.SyncCourseDepartment.Request;
using Business.Dtos.SyncCourseDepartment.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class SyncCourseDepartmentMappingProfile : Profile
{
    public SyncCourseDepartmentMappingProfile()
    {
        //create
        CreateMap<SyncCourseDepartment, CreateSyncCourseDepartmentRequest>().ReverseMap();
        CreateMap<SyncCourseDepartment, CreatedSyncCourseDepartmentResponse>().ReverseMap();
        CreateMap<CreatedSyncCourseDepartmentResponse, CreateSyncCourseDepartmentRequest>().ReverseMap();
        //list
        CreateMap<SyncCourseDepartment, GetListSyncCourseDepartmentResponse>().ReverseMap();
        CreateMap<SyncCourseDepartment, GetByIdSyncCourseDepartmentResponse>().ReverseMap();
        CreateMap<IPaginate<SyncCourseDepartment>, Paginate<GetListSyncCourseDepartmentResponse>>();
        //delete
        CreateMap<DeleteSyncCourseDepartmentRequest, DeletedSyncCourseDepartmentResponse>().ReverseMap();
        //update
        CreateMap<SyncCourseDepartment, UpdateSyncCourseDepartmentRequest>().ReverseMap();
        CreateMap<UpdateSyncCourseDepartmentRequest, UpdatedSyncCourseDepartmentResponse>().ReverseMap();
    }
}