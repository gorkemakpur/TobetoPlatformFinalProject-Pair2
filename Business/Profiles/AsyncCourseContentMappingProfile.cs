using AutoMapper;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AsyncCourseContent.Request;
using Business.Dtos.AsyncCourseContent.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AsyncCourseContentMappingProfile: Profile
    {
        public AsyncCourseContentMappingProfile()
        {
            //create
            CreateMap<AsyncCourseContentMappingProfile, CreateAsyncCourseContentRequest>().ReverseMap();
            CreateMap<AsyncCourseContentMappingProfile, CreatedAsyncCourseContentResponse>().ReverseMap();
            CreateMap<CreatedAsyncCourseContentResponse, CreateAsyncCourseContentRequest>().ReverseMap();
            //list
            CreateMap<AsyncCourseContentMappingProfile, GetListAsyncCourseContentResponse>().ReverseMap();
            CreateMap<AsyncCourseContentMappingProfile, GetByIdAsyncCourseContentResponse>().ReverseMap();
            CreateMap<IPaginate<AsyncCourseContentMappingProfile>, Paginate<GetListAsyncCourseContentResponse>>();
            //delete
            CreateMap<DeleteAsyncCourseContentRequest, DeletedAsyncCourseContentResponse>().ReverseMap();
            //update
            CreateMap<AsyncCourseContentMappingProfile, UpdateAsyncCourseContentRequest>().ReverseMap();
            CreateMap<UpdateAsyncCourseContentRequest, UpdatedAsyncCourseContentResponse>().ReverseMap();
        }
    }
}
