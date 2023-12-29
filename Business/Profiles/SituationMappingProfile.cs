using AutoMapper;
using Business.Dtos.Situation.Request;
using Business.Dtos.Situation.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class SituationMappingProfile : Profile
{
    public SituationMappingProfile()
    {
        //create
        CreateMap<Situation, CreateSituationRequest>().ReverseMap();
        CreateMap<Situation, CreatedSituationResponse>().ReverseMap();
        CreateMap<CreatedSituationResponse, CreateSituationRequest>().ReverseMap();
        //get
        CreateMap<Situation, GetListSituationResponse>().ReverseMap();
        CreateMap<Situation, GetByIdSituationResponse>().ReverseMap();
        CreateMap<IPaginate<Situation>, Paginate<GetListSituationResponse>>();
        //update
        CreateMap<Situation, UpdateSituationRequest>().ReverseMap();
        CreateMap<Situation, UpdatedSituationResponse>().ReverseMap();
        CreateMap<UpdatedSituationResponse, UpdateSituationRequest>().ReverseMap();
        //delete
        CreateMap<DeleteSituationRequest, DeletedSituationResponse>().ReverseMap();
    }

}
