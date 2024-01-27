using AutoMapper;
using Business.Dtos.StudentInformation.Request;
using Business.Dtos.StudentInformation.Response;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Profiles
{
    public class StudentInformationMappingProfile : Profile
    {
        public StudentInformationMappingProfile()
        {

            //create
            CreateMap<StudentInformation, CreateStudentInformationRequest>().ReverseMap();
            CreateMap<StudentInformation, CreatedStudentInformationResponse>().ReverseMap();
            CreateMap<CreatedStudentInformationResponse, CreateStudentInformationRequest>().ReverseMap();
            //list
            CreateMap<StudentInformation, GetListStudentInformationResponse>().ReverseMap();
            CreateMap<StudentInformation, GetByIdStudentInformationResponse>().ReverseMap();
            CreateMap<IPaginate<StudentInformation>, Paginate<GetListStudentInformationResponse>>();
            //delete
            CreateMap<DeleteStudentInformationRequest, DeletedStudentInformationResponse>().ReverseMap();
            //update
            CreateMap<StudentInformation, UpdateStudentInformationRequest>().ReverseMap();
            CreateMap<UpdateStudentInformationRequest, UpdatedStudentInformationResponse>().ReverseMap();
        }
    }

}
