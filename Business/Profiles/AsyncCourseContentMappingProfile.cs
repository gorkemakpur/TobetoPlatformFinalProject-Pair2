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
            CreateMap<AsyncCourseContent, CreateAsyncCourseContentRequest>().ReverseMap();
            CreateMap<AsyncCourseContent, CreatedAsyncCourseContentResponse>().ReverseMap();
            CreateMap<CreatedAsyncCourseContentResponse, CreateAsyncCourseContentRequest>().ReverseMap();
            //list
            CreateMap<AsyncCourseContent, GetListAsyncCourseContentResponse>().ReverseMap();
            CreateMap<AsyncCourseContent, GetByIdAsyncCourseContentResponse>().ReverseMap();
            CreateMap<AsyncCourseContent, GetByAsyncCourseIdResponse>().ReverseMap();

            CreateMap<IPaginate<AsyncCourseContent>, Paginate<GetListAsyncCourseContentResponse>>();
            //delete
            CreateMap<DeleteAsyncCourseContentRequest, DeletedAsyncCourseContentResponse>().ReverseMap();
            //update
            CreateMap<AsyncCourseContent, UpdateAsyncCourseContentRequest>().ReverseMap();
            CreateMap<UpdateAsyncCourseContentRequest, UpdatedAsyncCourseContentResponse>().ReverseMap();
        }
    }
}
