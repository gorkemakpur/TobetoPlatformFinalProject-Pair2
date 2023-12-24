using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Instructor.Request;
using Business.Dtos.Instructor.Response;
using DataAccess.Abstracts;
using Entities.Concretes;
using Core.DataAccess.Paging;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorDal _instructorDal;
        private readonly IMapper _mapper;
        public InstructorManager(IInstructorDal instructorDal, IMapper mapper)
        {
            _instructorDal = instructorDal;
            _mapper = mapper;
        }


        public async Task<CreatedInstructorResponse> AddAsync(CreateInstructorRequest createInstructorRequest)
        {
            var instructor = _mapper.Map<Instructor>(createInstructorRequest);
            var result = await _instructorDal.AddAsync(instructor);
            return _mapper.Map<CreatedInstructorResponse>(result);
        }

        public async Task<DeletedInstructorResponse> DeleteAsync(DeleteInstructorRequest deleteInstructorRequest)
        {
            var instructor = await _instructorDal.GetAsync(x => x.Id == deleteInstructorRequest.Id);
            var result = await _instructorDal.DeleteAsync(instructor);
            return _mapper.Map<DeletedInstructorResponse>(result);
        }

        public async Task<UpdatedInstructorResponse> UpdateAsync(UpdateInstructorRequest updateInstructorRequest)
        {
            var instructor = await _instructorDal.GetAsync(x => x.Id == updateInstructorRequest.Id);
            _mapper.Map(updateInstructorRequest, instructor);
            var result = await _instructorDal.UpdateAsync(instructor);
            return _mapper.Map<UpdatedInstructorResponse>(result);
        }

        public async Task<IPaginate<GetListInstructorResponse>> GetListAsync()
        {
            var instructors = await _instructorDal.GetListAsync();
            return _mapper.Map<Paginate<GetListInstructorResponse>>(instructors);
        }
        
        public async Task<GetByIdInstructorResponse> GetByIdAsync(Guid id)
        {
            var instructor = await _instructorDal.GetAsync(x=>x.Id == id);
            return _mapper.Map<GetByIdInstructorResponse>(instructor);
        }
    }

}
