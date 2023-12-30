using AutoMapper;
using Business.Dtos.LanguageLevel.Request;
using Business.Dtos.LanguageLevel.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class LanguageLevelMappingProfile : Profile
{
    public LanguageLevelMappingProfile()
    {
        //create
        CreateMap<LanguageLevel, CreateLanguageLevelRequest>().ReverseMap();
        CreateMap<LanguageLevel, CreatedLanguageLevelResponse>().ReverseMap();
        CreateMap<CreatedLanguageLevelResponse, CreateLanguageLevelRequest>().ReverseMap();
        //list
        CreateMap<LanguageLevel, GetListLanguageLevelResponse>().ReverseMap();
        CreateMap<LanguageLevel, GetByIdLanguageLevelResponse>().ReverseMap();
        CreateMap<IPaginate<LanguageLevel>, Paginate<GetListLanguageLevelResponse>>();
        //delete
        CreateMap<DeleteLanguageLevelRequest, DeletedLanguageLevelResponse>().ReverseMap();
        //update
        CreateMap<LanguageLevel, UpdateLanguageLevelRequest>().ReverseMap();
        CreateMap<UpdateLanguageLevelRequest, UpdatedLanguageLevelResponse>().ReverseMap();
    }
}