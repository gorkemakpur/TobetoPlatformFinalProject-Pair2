using Business.Abstracts;
using Business.Dtos.Category.Request;
using Business.Dtos.Category.Response;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //controller oluştururken burası basecontrollerdan miras alıp otomatik controller olacak şekilde tasarlandı
    //düz class oluşturduktan sonra basecontroller üzerinden miras alıp hızlıca onun api olduğunu tanıtabiliriz
    public class CategoriesController : BaseController
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteCategoryRequest DeleteCategoryRequest)
        {
            var result = await _categoryService.DeleteAsync(DeleteCategoryRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequest createCategoryRequest)
        {
            var result = await _categoryService.AddAsync(createCategoryRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _categoryService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _categoryService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateCategoryRequest updateCategoryRequest)
        {
            var result = await _categoryService.UpdateAsync(updateCategoryRequest);
            return Ok(result);
        }
    }
}
