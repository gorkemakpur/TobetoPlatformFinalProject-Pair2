using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Category.Request;
using Core.DataAccess.Paging;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using DataAccess.Concretes.EntityFramework;
using Business.Dtos.Category.Response;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        private readonly IMapper _mapper;

        public CategoryManager(ICategoryDal categoryDal, IMapper mapper)
        {
            _categoryDal = categoryDal;
            _mapper = mapper;
        }

        public async Task<CreatedCategoryResponse> AddAsync(CreateCategoryRequest createCategoryRequest)
        {
            Category addCategory = _mapper.Map<Category>(createCategoryRequest);
            Category createdCategory = await _categoryDal.AddAsync(addCategory);
            CreatedCategoryResponse createdCategoryResponse = _mapper.Map<CreatedCategoryResponse>(createdCategory);
            return createdCategoryResponse;
        }

        public async Task<DeletedCategoryResponse> DeleteAsync(DeleteCategoryRequest deleteCategoryRequest)
        {
            Category removeCategory = await _categoryDal.GetAsync(predicate: c => c.Id == deleteCategoryRequest.Id);
            await _categoryDal.DeleteAsync(removeCategory);
            DeletedCategoryResponse deletedCategoryResponse = _mapper.Map<DeletedCategoryResponse>(deleteCategoryRequest);
            return deletedCategoryResponse;
        }

        public async Task<GetByIdCategoryResponse> GetByIdAsync(Guid id)
        {
            Category result = await _categoryDal.GetAsync(predicate:c => c.Id == id);
            GetByIdCategoryResponse data = _mapper.Map<GetByIdCategoryResponse>(result);
            return data;
        }

        public async Task<IPaginate<GetListCategoryResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _categoryDal.GetListAsync(
                index: 0, // pageRequest.PageIndex,
                size: 10   // pageRequest.PageSize
            );

            var result = _mapper.Map<Paginate<GetListCategoryResponse>>(data);
            return result;
        }

        public async Task<UpdatedCategoryResponse> UpdateAsync(UpdateCategoryRequest updateCategoryRequest)
        {
            Category updateCategory = await _categoryDal.GetAsync(predicate:c => c.Id == updateCategoryRequest.Id);
            _mapper.Map(updateCategoryRequest, updateCategory);
            Category updatedCategory = await _categoryDal.UpdateAsync(updateCategory);
            UpdatedCategoryResponse updatedCategoryResponse = _mapper.Map<UpdatedCategoryResponse>(updatedCategory);
            return updatedCategoryResponse;
        }

    }
}