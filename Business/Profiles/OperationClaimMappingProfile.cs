using AutoMapper;
using Business.Dtos.OperationClaim.Request;
using Business.Dtos.OperationClaim.Response;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
using Entities.Concretes;

namespace Business.Profiles
{
    public class OperationClaimMappingProfile : Profile
    {
        public OperationClaimMappingProfile()
        {

            //create
            CreateMap<OperationClaim, CreateOperationClaimRequest>().ReverseMap();
            CreateMap<OperationClaim, CreatedOperationClaimResponse>().ReverseMap();
            CreateMap<CreatedOperationClaimResponse, CreateOperationClaimRequest>().ReverseMap();
            //list
            CreateMap<OperationClaim, GetListOperationClaimResponse>().ReverseMap();
            CreateMap<OperationClaim, GetByIdOperationClaimResponse>().ReverseMap();
            CreateMap<IPaginate<OperationClaim>, Paginate<GetListOperationClaimResponse>>();
            //delete
            CreateMap<DeleteOperationClaimRequest, DeletedOperationClaimResponse>().ReverseMap();
            //update
            CreateMap<OperationClaim, UpdateOperationClaimRequest>().ReverseMap();
            CreateMap<UpdateOperationClaimRequest, UpdatedOperationClaimResponse>().ReverseMap();
        }
    }

}
