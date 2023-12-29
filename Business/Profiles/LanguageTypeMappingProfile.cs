using AutoMapper;
using Business.Dtos.LanguageType.Request;
using Business.Dtos.LanguageType.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class LanguageTypeMappingProfile : Profile
{
    public LanguageTypeMappingProfile()
    {
        //create
        CreateMap<LanguageType, CreateLanguageTypeRequest>().ReverseMap();
        CreateMap<LanguageType, CreatedLanguageTypeResponse>().ReverseMap();
        CreateMap<CreatedLanguageTypeResponse, CreateLanguageTypeRequest>().ReverseMap();
        //get
        CreateMap<LanguageType, GetListLanguageTypeResponse>().ReverseMap();
        CreateMap<LanguageType, GetByIdLanguageTypeResponse>().ReverseMap();
        CreateMap<IPaginate<LanguageType>, Paginate<GetListLanguageTypeResponse>>();
        //update
        CreateMap<LanguageType, UpdateLanguageTypeRequest>().ReverseMap();
        CreateMap<LanguageType, UpdatedLanguageTypeResponse>().ReverseMap();
        CreateMap<UpdatedLanguageTypeResponse, UpdateLanguageTypeRequest>().ReverseMap();
        //delete
        CreateMap<DeleteLanguageTypeRequest, DeletedLanguageTypeResponse>().ReverseMap();
    }

}
