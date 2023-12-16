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
    public class AnnouncementTypeProfile : Profile
    {
        public AnnouncementTypeProfile()
        {
            CreateMap<AnnouncementType, CreateAnnouncementTypeRequest>().ReverseMap();
            CreateMap<AnnouncementType, CreatedAnnouncementTypeResponse>().ReverseMap();
            CreateMap<AnnouncementType, GetListAnnouncementTypeResponse>().ReverseMap();
            CreateMap<IPaginate<AnnouncementType>, Paginate<GetListAnnouncementTypeResponse>>();

            CreateMap<CreatedAnnouncementTypeResponse, CreateAnnouncementTypeRequest>().ReverseMap();
        }

    }
}
