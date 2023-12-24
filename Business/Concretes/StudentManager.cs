using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Student.Request;
using Business.Dtos.Student.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    //Student eklenirken, güncellenirken ve silinirken User işlemleri de yapılmalı. UserService tamamlandıktan sonra buraya eklenecek.
    public class StudentManager : IStudentService
    {
        private readonly IStudentDal _studentDal;
        private readonly IMapper _mapper;

        public StudentManager(IStudentDal studentDal, IMapper mapper)
        {
            _studentDal = studentDal;
            _mapper = mapper;
        }

        public async Task<CreatedStudentResponse> AddAsync(CreateStudentRequest createStudentRequest)
        {
            Student addStudent = _mapper.Map<Student>(createStudentRequest);

            Student createdStudent = await _studentDal.AddAsync(addStudent);

            CreatedStudentResponse createdStudentResponse = _mapper.Map<CreatedStudentResponse>(createdStudent);
            return createdStudentResponse;
        }

        public async Task<DeletedStudentResponse> DeleteAsync(DeleteStudentRequest deleteStudentRequest)
        {
            Student removeStudent = await _studentDal.GetAsync(predicate: s => s.Id == deleteStudentRequest.Id);

            await _studentDal.DeleteAsync(removeStudent);

            DeletedStudentResponse deletedStudentResponse = _mapper.Map<DeletedStudentResponse>(deleteStudentRequest);
            return deletedStudentResponse;
        }

        public async Task<GetByIdStudentResponse> GetByIdAsync(Guid id)
        {
            Student result = await _studentDal.GetAsync(predicate: s => s.Id == id);
            GetByIdStudentResponse data = _mapper.Map<GetByIdStudentResponse>(result);
            return data;
        }

        public async Task<IPaginate<GetListStudentResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _studentDal.GetListAsync(
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListStudentResponse>>(data);
            return result;
        }

        public async Task<UpdatedStudentResponse> UpdateAsync(UpdateStudentRequest updateStudentRequest)
        {
            Student updateStudent = await _studentDal.GetAsync(predicate: s => s.Id == updateStudentRequest.Id);

            _mapper.Map(updateStudentRequest, updateStudent);

            Student updatedStudent = await _studentDal.UpdateAsync(updateStudent);

            UpdatedStudentResponse updatedStudentResponse = _mapper.Map<UpdatedStudentResponse>(updatedStudent);

            return updatedStudentResponse;
        }
    }
}
