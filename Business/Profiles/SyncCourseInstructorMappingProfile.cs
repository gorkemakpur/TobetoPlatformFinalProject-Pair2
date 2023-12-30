using AutoMapper;
using Business.Dtos.SyncCourseInstructor.Request;
using Business.Dtos.SyncCourseInstructor.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class SyncCourseInstructorMappingProfile : Profile
{
    public SyncCourseInstructorMappingProfile()
    {
        //create
        CreateMap<SyncCourseInstructor, CreateSyncCourseInstructorRequest>().ReverseMap();
        CreateMap<SyncCourseInstructor, CreatedSyncCourseInstructorResponse>().ReverseMap();
        CreateMap<CreatedSyncCourseInstructorResponse, CreateSyncCourseInstructorRequest>().ReverseMap();
        //list
        CreateMap<SyncCourseInstructor, GetListSyncCourseInstructorResponse>().ReverseMap();
        CreateMap<SyncCourseInstructor, GetByIdSyncCourseInstructorResponse>().ReverseMap();
        CreateMap<IPaginate<SyncCourseInstructor>, Paginate<GetListSyncCourseInstructorResponse>>();
        //delete
        CreateMap<DeleteSyncCourseInstructorRequest, DeletedSyncCourseInstructorResponse>().ReverseMap();
        //update
        CreateMap<SyncCourseInstructor, UpdateSyncCourseInstructorRequest>().ReverseMap();
        CreateMap<UpdateSyncCourseInstructorRequest, UpdatedSyncCourseInstructorResponse>().ReverseMap();
    }
}