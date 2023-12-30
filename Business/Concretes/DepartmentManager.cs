using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Department.Request;
using Business.Dtos.Department.Response;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;
        private readonly IMapper _mapper;

        public DepartmentManager(IDepartmentDal departmentDal, IMapper mapper)
        {
            _departmentDal = departmentDal;
            _mapper = mapper;
        }

        public async Task<CreatedDepartmentResponse> AddAsync(CreateDepartmentRequest createDepartmentRequest)
        {
            var department = _mapper.Map<Department>(createDepartmentRequest);
            var result = await _departmentDal.AddAsync(department);
            return _mapper.Map<CreatedDepartmentResponse>(result);
        }

        public async Task<DeletedDepartmentResponse> DeleteAsync(DeleteDepartmentRequest deleteDepartmentRequest)
        {
            var department = await _departmentDal.GetAsync(x => x.Id == deleteDepartmentRequest.Id);
            var result = await _departmentDal.DeleteAsync(department);
            return _mapper.Map<DeletedDepartmentResponse>(result);
        }

        public async Task<UpdatedDepartmentResponse> UpdateAsync(UpdateDepartmentRequest updateDepartmentRequest)
        {
            var department = await _departmentDal.GetAsync(x => x.Id == updateDepartmentRequest.Id);
            _mapper.Map(updateDepartmentRequest, department);
            var result = await _departmentDal.UpdateAsync(department);
            return _mapper.Map<UpdatedDepartmentResponse>(result);
        }

        public async Task<IPaginate<GetListDepartmentResponse>> GetListAsync()
        {
            var departments = await _departmentDal.GetListAsync();
            return _mapper.Map<Paginate<GetListDepartmentResponse>>(departments);
        }
        
        public async Task<GetByIdDepartmentResponse> GetByIdAsync(Guid id)
        {
            var department = await _departmentDal.GetAsync(x=>x.Id == id);
            return _mapper.Map<GetByIdDepartmentResponse>(department);
        }
    }

}
