using Business.Abstracts;
using Business.Dtos.AsyncCourseDepartment.Request;
using Business.Dtos.AsyncCourseDepartment.Response;
using Business.Dtos.SyncCourseDepartment.Request;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    //controller oluştururken burası basecontrollerdan miras alıp otomatik controller olacak şekilde tasarlandı
    //düz class oluşturduktan sonra basecontroller üzerinden miras alıp hızlıca onun api olduğunu tanıtabiliriz
    public class AsyncCourseDepartmentsController : BaseController
    {
        IAsyncCourseDepartmentService _asyncCourseDepartmentService;

        public AsyncCourseDepartmentsController(IAsyncCourseDepartmentService asyncCourseDepartmentService)
        {
            _asyncCourseDepartmentService = asyncCourseDepartmentService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteAsyncCourseDepartmentRequest DeleteAsyncCourseDepartmentRequest)
        {
            var result = await _asyncCourseDepartmentService.DeleteAsync(DeleteAsyncCourseDepartmentRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateAsyncCourseDepartmentRequest createAsyncCourseDepartmentRequest)
        {
            var result = await _asyncCourseDepartmentService.AddAsync(createAsyncCourseDepartmentRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            var result = await _asyncCourseDepartmentService.GetListAsync(pageRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _asyncCourseDepartmentService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateAsyncCourseDepartmentRequest updateAsyncCourseDepartmentRequest)
        {
            var result = await _asyncCourseDepartmentService.UpdateAsync(updateAsyncCourseDepartmentRequest);
            return Ok(result);
        }
    }
}
