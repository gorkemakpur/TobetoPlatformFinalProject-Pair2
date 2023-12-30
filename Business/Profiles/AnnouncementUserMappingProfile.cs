using AutoMapper;
using Business.Dtos.AnnouncementUser.Request;
using Business.Dtos.AnnouncementUser.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class AnnouncementUserMappingProfile : Profile
{
    public AnnouncementUserMappingProfile()
    {
        //create
        CreateMap<AnnouncementUser, CreateAnnouncementUserRequest>().ReverseMap();
        CreateMap<AnnouncementUser, CreatedAnnouncementUserResponse>().ReverseMap();
        CreateMap<CreatedAnnouncementUserResponse, CreateAnnouncementUserRequest>().ReverseMap();
        //list
        CreateMap<AnnouncementUser, GetListAnnouncementUserResponse>().ReverseMap();
        CreateMap<AnnouncementUser, GetByIdAnnouncementUserResponse>().ReverseMap();
        CreateMap<IPaginate<AnnouncementUser>, Paginate<GetListAnnouncementUserResponse>>();
        //delete
        CreateMap<DeleteAnnouncementUserRequest, DeletedAnnouncementUserResponse>().ReverseMap();
        //update
        CreateMap<AnnouncementUser, UpdateAnnouncementUserRequest>().ReverseMap();
        CreateMap<UpdateAnnouncementUserRequest, UpdatedAnnouncementUserResponse>().ReverseMap();
    }
}