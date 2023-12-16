using AutoMapper;
using Business.Abstracts;
using DataAccess.Abstracts;

namespace Business.Concretes
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;
        private readonly IMapper _mapper;

        public StudentManager(IStudentDal studentDal, IMapper mapper)
        {
            _studentDal = studentDal;
            _mapper = mapper;
        }

        // İlgili metotlar
    }

}
