using AutoMapper;
using Business.Dtos.SyncCourse.Request;
using Business.Dtos.SyncCourse.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class SyncCourseMappingProfile : Profile
    {
        public SyncCourseMappingProfile()
        {

            //create
            CreateMap<SyncCourse, CreateSyncCourseRequest>().ReverseMap();
            CreateMap<SyncCourse, CreatedSyncCourseResponse>().ReverseMap();
            CreateMap<CreatedSyncCourseResponse, CreateSyncCourseRequest>().ReverseMap();
            //list
            CreateMap<SyncCourse, GetListSyncCourseResponse>().ReverseMap();
            CreateMap<SyncCourse, GetByIdSyncCourseResponse>().ReverseMap();
            CreateMap<IPaginate<SyncCourse>, Paginate<GetListSyncCourseResponse>>();
            //delete
            CreateMap<DeleteSyncCourseRequest, DeletedSyncCourseResponse>().ReverseMap();
            //update
            CreateMap<SyncCourse, UpdateSyncCourseRequest>().ReverseMap();
            CreateMap<UpdateSyncCourseRequest, UpdatedSyncCourseResponse>().ReverseMap();
        }
    }

}
