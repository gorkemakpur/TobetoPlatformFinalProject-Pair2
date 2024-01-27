using AutoMapper;
using Business.Dtos.UserOperationClaim.Request;
using Business.Dtos.UserOperationClaim.Response;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;

namespace Business.Profiles
{
    public class UserOperationClaimMappingProfile : Profile
    {
        public UserOperationClaimMappingProfile()
        {

            //create
            CreateMap<UserOperationClaim, CreateUserOperationClaimRequest>().ReverseMap();
            CreateMap<UserOperationClaim, CreatedUserOperationClaimResponse>().ReverseMap();
            CreateMap<CreatedUserOperationClaimResponse, CreateUserOperationClaimRequest>().ReverseMap();
            //list
            CreateMap<UserOperationClaim, GetListUserOperationClaimResponse>().ReverseMap();
            CreateMap<UserOperationClaim, GetByIdUserOperationClaimResponse>().ReverseMap();
            CreateMap<IPaginate<UserOperationClaim>, Paginate<GetListUserOperationClaimResponse>>();
            //delete
            CreateMap<DeleteUserOperationClaimRequest, DeletedUserOperationClaimResponse>().ReverseMap();
            //update
            CreateMap<UserOperationClaim, UpdateUserOperationClaimRequest>().ReverseMap();
            CreateMap<UpdateUserOperationClaimRequest, UpdatedUserOperationClaimResponse>().ReverseMap();
        }
    }

}
