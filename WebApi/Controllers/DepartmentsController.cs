using Business.Abstracts;
using Business.Dtos.Department.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class DepartmentsController : BaseController
    {
        IDepartmentService _departmentService;

        public DepartmentsController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteDepartmentRequest DeleteDepartmentRequest)
        {
            var result = await _departmentService.DeleteAsync(DeleteDepartmentRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateDepartmentRequest createDepartmentRequest)
        {
            var result = await _departmentService.AddAsync(createDepartmentRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _departmentService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _departmentService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateDepartmentRequest updateDepartmentRequest)
        {
            var result = await _departmentService.UpdateAsync(updateDepartmentRequest);
            return Ok(result);
        }
    }
}
