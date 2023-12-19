using AutoMapper;
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
    public class AnnouncementTypeMappingProfile : Profile
    {
        public AnnouncementTypeMappingProfile()
        {
            //create
            CreateMap<AnnouncementType, CreateAnnouncementTypeRequest>().ReverseMap();
            CreateMap<AnnouncementType, CreatedAnnouncementTypeResponse>().ReverseMap();
            CreateMap<CreatedAnnouncementTypeResponse, CreateAnnouncementTypeRequest>().ReverseMap();
            //get
            CreateMap<AnnouncementType, GetListAnnouncementTypeResponse>().ReverseMap();
            CreateMap<AnnouncementType, GetByIdAnnouncementTypeResponse>().ReverseMap();
            CreateMap<IPaginate<AnnouncementType>, Paginate<GetListAnnouncementTypeResponse>>();
            //update
            CreateMap<AnnouncementType, UpdateAnnouncementTypeRequest>().ReverseMap();
            CreateMap<AnnouncementType, UpdatedAnnouncementTypeResponse>().ReverseMap();
            CreateMap<UpdatedAnnouncementTypeResponse, UpdateAnnouncementTypeRequest>().ReverseMap();
            //delete
            CreateMap<DeleteAnnouncementTypeRequest, DeletedAnnouncementTypeResponse>().ReverseMap();




        }

    }
}
