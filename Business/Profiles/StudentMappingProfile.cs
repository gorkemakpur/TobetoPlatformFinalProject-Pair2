using AutoMapper;
using Business.Dtos.Student.Request;
using Business.Dtos.Student.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles;

public class StudentMappingProfile : Profile
{
    public StudentMappingProfile()
    {
        //create
        CreateMap<Student, CreateStudentRequest>().ReverseMap();
        CreateMap<Student, CreatedStudentResponse>().ReverseMap();
        CreateMap<CreatedStudentResponse, CreateStudentRequest>().ReverseMap();
        //get
        CreateMap<Student, GetListStudentResponse>().ReverseMap();
        CreateMap<Student, GetByIdStudentResponse>().ReverseMap();
        CreateMap<IPaginate<Student>, Paginate<GetListStudentResponse>>();
        //update
        CreateMap<Student, UpdateStudentRequest>().ReverseMap();
        CreateMap<Student, UpdatedStudentResponse>().ReverseMap();
        CreateMap<UpdatedStudentResponse, UpdateStudentRequest>().ReverseMap();
        //delete
        CreateMap<DeleteStudentRequest, DeletedStudentResponse>().ReverseMap();
    }

}
