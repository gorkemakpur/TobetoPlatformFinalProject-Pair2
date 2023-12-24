using AutoMapper;
using Business.Dtos.Announcement.Request;
using Business.Dtos.Announcement.Response;
using Business.Dtos.Instructor.Request;
using Business.Dtos.Instructor.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class InstructorMappingProfile : Profile
{
    public InstructorMappingProfile()
    {
        //create
        CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
        CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
        CreateMap<CreatedInstructorResponse, CreateInstructorRequest>().ReverseMap();
        //list
        CreateMap<Instructor, GetListInstructorResponse>().ReverseMap();
        CreateMap<Instructor, GetByIdInstructorResponse>().ReverseMap();
        CreateMap<IPaginate<Instructor>, Paginate<GetListInstructorResponse>>();
        //delete
        CreateMap<DeleteInstructorRequest, DeletedInstructorResponse>().ReverseMap();
        //update
        CreateMap<Instructor, UpdateInstructorRequest>().ReverseMap();
        CreateMap<UpdateInstructorRequest, UpdatedInstructorResponse>().ReverseMap();
    }
}