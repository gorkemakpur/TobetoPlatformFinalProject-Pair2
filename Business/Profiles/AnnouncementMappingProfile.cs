using AutoMapper;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.AnnouncementType.Request;
using Business.Dtos.AnnouncementType.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class AnnouncementMappingProfile : Profile
    {
        public AnnouncementMappingProfile()
        {

            //create
            CreateMap<Announcement, CreateAnnouncementRequest>().ReverseMap();
            CreateMap<Announcement, CreatedAnnouncementResponse>().ReverseMap();
            CreateMap<CreatedAnnouncementResponse, CreateAnnouncementRequest>().ReverseMap();
            //list
            CreateMap<Announcement, GetListAnnouncementResponse>().ReverseMap();
            CreateMap<Announcement, GetByIdAnnouncementResponse>().ReverseMap();
            CreateMap<IPaginate<Announcement>, Paginate<GetListAnnouncementResponse>>();
            //delete
            CreateMap<DeleteAnnouncementRequest, DeletedAnnouncementResponse>().ReverseMap();
            //update
            CreateMap<Announcement, UpdateAnnouncementRequest>().ReverseMap();
            CreateMap<UpdateAnnouncementRequest, UpdatedAnnouncementResponse>().ReverseMap();




        }
    }
}
