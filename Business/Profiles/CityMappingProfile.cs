using AutoMapper;
using Business.Dtos.City.Request;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.City.Response;

namespace Business.Profiles
{
    public class CityMappingProfile : Profile
    {
        public CityMappingProfile()
        {

            //create
            CreateMap<City, CreateCityRequest>().ReverseMap();
            CreateMap<City, CreatedCityResponse>().ReverseMap();
            CreateMap<CreatedCityResponse, CreateCityRequest>().ReverseMap();
            //list
            CreateMap<City, GetListCityResponse>().ReverseMap();
            CreateMap<City, GetByIdCityResponse>().ReverseMap();
            CreateMap<IPaginate<City>, Paginate<GetListCityResponse>>();
            //delete
            CreateMap<DeleteCityRequest, DeletedCityResponse>().ReverseMap();
            //update
            CreateMap<City, UpdateCityRequest>().ReverseMap();
            CreateMap<UpdateCityRequest, UpdatedCityResponse>().ReverseMap();
        }
    }
}
