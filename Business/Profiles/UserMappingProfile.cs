using AutoMapper;
using Business.Dtos.Auth.Request;
using Business.Dtos.Auth.Response;
using Business.Dtos.User.Request;
using Business.Dtos.User.Response;
using Core.DataAccess.Paging;
using Core.Entities.Concrete;
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
            CreateMap<User, GetUserResponse>().ReverseMap();
            CreateMap<Paginate<User>, Paginate<GetListUserResponse>>().ReverseMap();
            //delete
            CreateMap<DeleteUserRequest, DeletedUserResponse>().ReverseMap();
            //update
            CreateMap<User, UpdateUserRequest>().ReverseMap();
            CreateMap<UpdateUserRequest, UpdatedUserResponse>().ReverseMap();
            //login
            CreateMap<User, LoginAuthRequest>().ReverseMap();
            CreateMap<User, LoginAuthResponse>().ReverseMap();
            CreateMap<GetUserResponse, LoginAuthResponse>().ReverseMap();
            //register
            CreateMap<User, RegisterAuthRequest>().ReverseMap();

            CreateMap<User, RegisterAuthResponse>().ReverseMap();
            CreateMap<GetUserResponse, RegisterAuthResponse>().ReverseMap();
        }
    }


}
