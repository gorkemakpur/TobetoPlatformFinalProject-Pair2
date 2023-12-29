using AutoMapper;
using Business.Dtos.User.Request;
using Business.Dtos.User.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {

            //create
            CreateMap<User, CreateUserRequest>().ReverseMap();
            CreateMap<User, CreatedUserResponse>().ReverseMap();
            CreateMap<CreatedUserResponse, CreateUserRequest>().ReverseMap();
            //list
            CreateMap<User, GetListUserResponse>().ReverseMap();
            CreateMap<User, GetByIdUserResponse>().ReverseMap();
            CreateMap<IPaginate<User>, Paginate<GetListUserResponse>>();
            //delete
            CreateMap<DeleteUserRequest, DeletedUserResponse>().ReverseMap();
            //update
            CreateMap<User, UpdateUserRequest>().ReverseMap();
            CreateMap<UpdateUserRequest, UpdatedUserResponse>().ReverseMap();
        }
    }

}
