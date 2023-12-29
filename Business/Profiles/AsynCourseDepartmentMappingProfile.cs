using AutoMapper;
using Business.Dtos.AsyncCourseDepartment.Request;
using Business.Dtos.AsyncCourseDepartment.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AsyncCourseDepartmentMappingProfile : Profile
    {
        public AsyncCourseDepartmentMappingProfile()
        {

            //create
            CreateMap<AsyncCourseDepartment, CreateAsyncCourseDepartmentRequest>().ReverseMap();
            CreateMap<AsyncCourseDepartment, CreatedAsyncCourseDepartmentResponse>().ReverseMap();
            CreateMap<CreatedAsyncCourseDepartmentResponse, CreateAsyncCourseDepartmentRequest>().ReverseMap();
            //list
            CreateMap<AsyncCourseDepartment, GetListAsyncCourseDepartmentResponse>().ReverseMap();
            CreateMap<AsyncCourseDepartment, GetByIdAsyncCourseDepartmentResponse>().ReverseMap();
            CreateMap<IPaginate<AsyncCourseDepartment>, Paginate<GetListAsyncCourseDepartmentResponse>>();
            //delete
            CreateMap<DeleteAsyncCourseDepartmentRequest, DeletedAsyncCourseDepartmentResponse>().ReverseMap();
            //update
            CreateMap<AsyncCourseDepartment, UpdateAsyncCourseDepartmentRequest>().ReverseMap();
            CreateMap<UpdateAsyncCourseDepartmentRequest, UpdatedAsyncCourseDepartmentResponse>().ReverseMap();
        }
    }
}
