using AutoMapper;
using Business.Dtos.Language.Request;
using Business.Dtos.Language.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class LanguageMappingProfile : Profile
{
    public LanguageMappingProfile()
    {
        //create
        CreateMap<Language, CreateLanguageRequest>().ReverseMap();
        CreateMap<Language, CreatedLanguageResponse>().ReverseMap();
        CreateMap<CreatedLanguageResponse, CreateLanguageRequest>().ReverseMap();
        //get
        CreateMap<Language, GetListLanguageResponse>().ReverseMap();
        CreateMap<Language, GetByIdLanguageResponse>().ReverseMap();
        CreateMap<IPaginate<Language>, Paginate<GetListLanguageResponse>>();
        //update
        CreateMap<Language, UpdateLanguageRequest>().ReverseMap();
        CreateMap<Language, UpdatedLanguageResponse>().ReverseMap();
        CreateMap<UpdatedLanguageResponse, UpdateLanguageRequest>().ReverseMap();
        //delete
        CreateMap<DeleteLanguageRequest, DeletedLanguageResponse>().ReverseMap();
    }

}
