using AutoMapper;
using Business.Dtos.SocialMediaName.Request;
using Business.Dtos.SocialMediaName.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class SocialMediaNameMappingProfile : Profile
    {
        public SocialMediaNameMappingProfile()
        {

            //create
            CreateMap<SocialMediaName, CreateSocialMediaNameRequest>().ReverseMap();
            CreateMap<SocialMediaName, CreatedSocialMediaNameResponse>().ReverseMap();
            CreateMap<CreatedSocialMediaNameResponse, CreateSocialMediaNameRequest>().ReverseMap();
            //list
            CreateMap<SocialMediaName, GetListSocialMediaNameResponse>().ReverseMap();
            CreateMap<SocialMediaName, GetByIdSocialMediaNameResponse>().ReverseMap();
            CreateMap<IPaginate<SocialMediaName>, Paginate<GetListSocialMediaNameResponse>>();
            //delete
            CreateMap<DeleteSocialMediaNameRequest, DeletedSocialMediaNameResponse>().ReverseMap();
            //update
            CreateMap<SocialMediaName, UpdateSocialMediaNameRequest>().ReverseMap();
            CreateMap<UpdateSocialMediaNameRequest, UpdatedSocialMediaNameResponse>().ReverseMap();
        }
    }

}
