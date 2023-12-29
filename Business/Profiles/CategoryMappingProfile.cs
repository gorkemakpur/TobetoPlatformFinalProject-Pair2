using AutoMapper;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Category.Response;
using Business.Dtos.Category.Request;

namespace Business.Profiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {

            //create
            CreateMap<Category, CreateCategoryRequest>().ReverseMap();
            CreateMap<Category, CreatedCategoryResponse>().ReverseMap();
            CreateMap<CreatedCategoryResponse, CreateCategoryRequest>().ReverseMap();
            //list
            CreateMap<Category, GetListCategoryResponse>().ReverseMap();
            CreateMap<Category, GetByIdCategoryResponse>().ReverseMap();
            CreateMap<IPaginate<Category>, Paginate<GetListCategoryResponse>>();
            //delete
            CreateMap<DeleteCategoryRequest, DeletedCategoryResponse>().ReverseMap();
            //update
            CreateMap<Category, UpdateCategoryRequest>().ReverseMap();
            CreateMap<UpdateCategoryRequest, UpdatedCategoryResponse>().ReverseMap();
        }
    }
}
