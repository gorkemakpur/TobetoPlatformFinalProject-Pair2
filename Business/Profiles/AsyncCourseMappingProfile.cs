using AutoMapper;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AsyncCourse.Request;
using Business.Dtos.AsyncCourse.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AsyncCourseMappingProfile : Profile
    {
        public AsyncCourseMappingProfile()
        {
            //create
            CreateMap<AsyncCourse, CreateAsyncCourseRequest>().ReverseMap();
            CreateMap<AsyncCourse, CreatedAsyncCourseResponse>().ReverseMap();
            CreateMap<CreatedAsyncCourseResponse, CreateAsyncCourseRequest>().ReverseMap();
            //list
            CreateMap<AsyncCourse, GetListAsyncCourseResponse>().ReverseMap();
            CreateMap<AsyncCourse, GetByIdAsyncCourseResponse>().ReverseMap();
            CreateMap<IPaginate<AsyncCourse>, Paginate<GetListAsyncCourseResponse>>();
            //delete
            CreateMap<DeleteAsyncCourseRequest, DeletedAsyncCourseResponse>().ReverseMap();
            //update
            CreateMap<AsyncCourse, UpdateAsyncCourseRequest>().ReverseMap();
            CreateMap<UpdateAsyncCourseRequest, UpdatedAsyncCourseResponse>().ReverseMap();
        }
    }
}
