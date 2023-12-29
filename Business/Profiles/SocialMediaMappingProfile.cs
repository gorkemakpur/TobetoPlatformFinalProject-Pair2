using AutoMapper;
using Business.Dtos.SocialMedia.Request;
using Business.Dtos.SocialMedia.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class SocialMediaMappingProfile : Profile
    {
        public SocialMediaMappingProfile()
        {

            //create
            CreateMap<SocialMedia, CreateSocialMediaRequest>().ReverseMap();
            CreateMap<SocialMedia, CreatedSocialMediaResponse>().ReverseMap();
            CreateMap<CreatedSocialMediaResponse, CreateSocialMediaRequest>().ReverseMap();
            //list
            CreateMap<SocialMedia, GetListSocialMediaResponse>().ReverseMap();
            CreateMap<SocialMedia, GetByIdSocialMediaResponse>().ReverseMap();
            CreateMap<IPaginate<SocialMedia>, Paginate<GetListSocialMediaResponse>>();
            //delete
            CreateMap<DeleteSocialMediaRequest, DeletedSocialMediaResponse>().ReverseMap();
            //update
            CreateMap<SocialMedia, UpdateSocialMediaRequest>().ReverseMap();
            CreateMap<UpdateSocialMediaRequest, UpdatedSocialMediaResponse>().ReverseMap();
        }
    }

}
