using AutoMapper;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.Application.Request;
using Business.Dtos.Application.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile() 
        {
            //create
            CreateMap<Application, CreateApplicationRequest>().ReverseMap();
            CreateMap<Application, CreatedApplicationResponse>().ReverseMap();
            CreateMap<CreateApplicationRequest, CreatedApplicationResponse>().ReverseMap();
            ////list
            CreateMap<Application, GetListApplicationResponse>().ReverseMap();
            CreateMap<Application, GetByIdApplicationResponse>().ReverseMap();
            CreateMap<IPaginate<Application>, Paginate<GetListApplicationResponse>>();
            ////delete
            CreateMap<DeleteApplicationRequest, DeletedApplicationResponse>().ReverseMap();
            ////update
            CreateMap<Application, UpdateApplicationRequest>().ReverseMap();
            CreateMap<UpdateApplicationRequest, UpdatedApplicationResponse>().ReverseMap();
        }
    }
}
