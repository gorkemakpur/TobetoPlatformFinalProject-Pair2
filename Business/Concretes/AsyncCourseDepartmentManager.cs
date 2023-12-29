using AutoMapper;
using Business.Abstracts;
using Business.Dtos.AsyncCourseDepartment.Request;
using Business.Dtos.AsyncCourseDepartment.Response;
using Core.DataAccess.Paging;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class AsyncCourseDepartmentManager : IAsyncCourseDepartmentService
    {
        private readonly IAsyncCourseDepartmentDal _asyncCourseDepartmentDal;
        private readonly IMapper _mapper;

        public AsyncCourseDepartmentManager(IAsyncCourseDepartmentDal asyncCourseDepartmentDal, IMapper mapper)
        {
            _asyncCourseDepartmentDal = asyncCourseDepartmentDal;
            _mapper = mapper;
        }

        public async Task<CreatedAsyncCourseDepartmentResponse> AddAsync(CreateAsyncCourseDepartmentRequest createAsyncCourseDepartmentRequest)
        {
            AsyncCourseDepartment addAsyncCourseDepartment = _mapper.Map<AsyncCourseDepartment>(createAsyncCourseDepartmentRequest);
            AsyncCourseDepartment createdAsyncCourseDepartment = await _asyncCourseDepartmentDal.AddAsync(addAsyncCourseDepartment);
            CreatedAsyncCourseDepartmentResponse createdAsyncCourseDepartmentResponse = _mapper.Map<CreatedAsyncCourseDepartmentResponse>(createdAsyncCourseDepartment);
            return createdAsyncCourseDepartmentResponse;
        }

        public async Task<DeletedAsyncCourseDepartmentResponse> DeleteAsync(DeleteAsyncCourseDepartmentRequest deleteAsyncCourseDepartmentRequest)
        {
            AsyncCourseDepartment removeAsyncCourseDepartment = await _asyncCourseDepartmentDal.GetAsync(predicate: at => at.Id == deleteAsyncCourseDepartmentRequest.Id);

            await _asyncCourseDepartmentDal.DeleteAsync(removeAsyncCourseDepartment);

            DeletedAsyncCourseDepartmentResponse deletedAsyncCourseDepartmentResponse = _mapper.Map<DeletedAsyncCourseDepartmentResponse>(deleteAsyncCourseDepartmentRequest);//bu kısıma tekrar bakılacak
            return deletedAsyncCourseDepartmentResponse;
        }

        public async Task<GetByIdAsyncCourseDepartmentResponse> GetByIdAsync(Guid id)
        {
            AsyncCourseDepartment result = await _asyncCourseDepartmentDal.GetAsync(predicate:at => at.Id == id);
            GetByIdAsyncCourseDepartmentResponse data = _mapper.Map<GetByIdAsyncCourseDepartmentResponse>(result);  
            return data;
        }

        public async Task<IPaginate<GetListAsyncCourseDepartmentResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _asyncCourseDepartmentDal.GetListAsync(
                index: 0,//pageRequest.PageIndex,
                size: 10 //pageRequest.PageSize
                );

            var result = _mapper.Map<Paginate<GetListAsyncCourseDepartmentResponse>>(data);
            return result;
        }

        public async Task<UpdatedAsyncCourseDepartmentResponse> UpdateAsync(UpdateAsyncCourseDepartmentRequest updateAsyncCourseDepartmentRequest)
        {
            AsyncCourseDepartment updateAsyncCourseDepartment = await _asyncCourseDepartmentDal.GetAsync(predicate:p => p.Id == updateAsyncCourseDepartmentRequest.Id);

            _mapper.Map(updateAsyncCourseDepartmentRequest, updateAsyncCourseDepartment);

            AsyncCourseDepartment updatedAsyncCourseDepartment = await _asyncCourseDepartmentDal.UpdateAsync(updateAsyncCourseDepartment);

            UpdatedAsyncCourseDepartmentResponse updatedAsyncCourseDepartmentResponse = _mapper.Map<UpdatedAsyncCourseDepartmentResponse>(updatedAsyncCourseDepartment);

            return updatedAsyncCourseDepartmentResponse;
        }

    }
}