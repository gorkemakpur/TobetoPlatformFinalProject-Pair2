using AutoMapper;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.SyncCourseContent.Response;
using Business.Dtos.SyncCourseContent.Request;


namespace Business.Profiles
{
    public class SyncCourseContentMappingProfile : Profile
    {
        public SyncCourseContentMappingProfile()
        {

            //create
            CreateMap<SyncCourseContent, CreateSyncCourseContentRequest>().ReverseMap();
            CreateMap<SyncCourseContent, CreatedSyncCourseContentResponse>().ReverseMap();
            CreateMap<CreatedSyncCourseContentResponse, CreateSyncCourseContentRequest>().ReverseMap();
            //list
            CreateMap<SyncCourseContent, GetListSyncCourseContentResponse>().ReverseMap();
            CreateMap<SyncCourseContent, GetByIdSyncCourseContentResponse>().ReverseMap();
            CreateMap<IPaginate<SyncCourseContent>, Paginate<GetListSyncCourseContentResponse>>();
            //delete
            CreateMap<DeleteSyncCourseContentRequest, DeletedSyncCourseContentResponse>().ReverseMap();
            //update
            CreateMap<SyncCourseContent, UpdateSyncCourseContentRequest>().ReverseMap();
            CreateMap<UpdateSyncCourseContentRequest, UpdatedSyncCourseContentResponse>().ReverseMap();
        }
    }
}
