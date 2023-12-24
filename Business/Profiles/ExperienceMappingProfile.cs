using AutoMapper;
using Business.Dtos.Experience.Request;
using Business.Dtos.Experience.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class ExperienceMappingProfile : Profile
{
    public ExperienceMappingProfile()
    {
        //create
        CreateMap<Experience, CreateExperienceRequest>().ReverseMap();
        CreateMap<Experience, CreatedExperienceResponse>().ReverseMap();
        CreateMap<CreatedExperienceResponse, CreateExperienceRequest>().ReverseMap();
        //list
        CreateMap<Experience, GetListExperienceResponse>().ReverseMap();
        CreateMap<Experience, GetByIdExperienceResponse>().ReverseMap();
        CreateMap<IPaginate<Experience>, Paginate<GetListExperienceResponse>>();
        //delete
        CreateMap<DeleteExperienceRequest, DeletedExperienceResponse>().ReverseMap();
        //update
        CreateMap<Experience, UpdateExperienceRequest>().ReverseMap();
        CreateMap<UpdateExperienceRequest, UpdatedExperienceResponse>().ReverseMap();
    }
}