using AutoMapper;
using Business.Dtos.Competence.Request;
using Business.Dtos.Competence.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class CompetenceMappingProfile : Profile
{
    public CompetenceMappingProfile()
    {
        //create
        CreateMap<Competence, CreateCompetenceRequest>().ReverseMap();
        CreateMap<Competence, CreatedCompetenceResponse>().ReverseMap();
        CreateMap<CreatedCompetenceResponse, CreateCompetenceRequest>().ReverseMap();
        //list
        CreateMap<Competence, GetListCompetenceResponse>().ReverseMap();
        CreateMap<Competence, GetByIdCompetenceResponse>().ReverseMap();
        CreateMap<IPaginate<Competence>, Paginate<GetListCompetenceResponse>>();
        //delete
        CreateMap<DeleteCompetenceRequest, DeletedCompetenceResponse>().ReverseMap();
        //update
        CreateMap<Competence, UpdateCompetenceRequest>().ReverseMap();
        CreateMap<UpdateCompetenceRequest, UpdatedCompetenceResponse>().ReverseMap();
    }
}