using AutoMapper;
using Business.Dtos.District.Request;
using Business.Dtos.District.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class DistrictMappingProfile : Profile
{
    public DistrictMappingProfile()
    {
        //create
        CreateMap<District, CreateDistrictRequest>().ReverseMap();
        CreateMap<District, CreatedDistrictResponse>().ReverseMap();
        CreateMap<CreatedDistrictResponse, CreateDistrictRequest>().ReverseMap();
        //list
        CreateMap<District, GetListDistrictResponse>().ReverseMap();
        CreateMap<District, GetByIdDistrictResponse>().ReverseMap();
        CreateMap<IPaginate<District>, Paginate<GetListDistrictResponse>>();
        //delete
        CreateMap<DeleteDistrictRequest, DeletedDistrictResponse>().ReverseMap();
        //update
        CreateMap<District, UpdateDistrictRequest>().ReverseMap();
        CreateMap<UpdateDistrictRequest, UpdatedDistrictResponse>().ReverseMap();
    }
}