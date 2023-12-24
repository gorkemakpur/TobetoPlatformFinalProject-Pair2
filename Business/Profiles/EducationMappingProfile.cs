using AutoMapper;
using Business.Dtos.Education.Request;
using Business.Dtos.Education.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class EducationMappingProfile : Profile
{
    public EducationMappingProfile()
    {
        //create
        CreateMap<Education, CreateEducationRequest>().ReverseMap();
        CreateMap<Education, CreatedEducationResponse>().ReverseMap();
        CreateMap<CreatedEducationResponse, CreateEducationRequest>().ReverseMap();
        //list
        CreateMap<Education, GetListEducationResponse>().ReverseMap();
        CreateMap<Education, GetByIdEducationResponse>().ReverseMap();
        CreateMap<IPaginate<Education>, Paginate<GetListEducationResponse>>();
        //delete
        CreateMap<DeleteEducationRequest, DeletedEducationResponse>().ReverseMap();
        //update
        CreateMap<Education, UpdateEducationRequest>().ReverseMap();
        CreateMap<UpdateEducationRequest, UpdatedEducationResponse>().ReverseMap();
    }
}