using AutoMapper;
using Business.Dtos.Instructor.Request;
using Business.Dtos.Instructor.Response;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class InstructorMappingProfile : Profile
    {
        public InstructorMappingProfile() 
        {
            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
        }
    }
}
