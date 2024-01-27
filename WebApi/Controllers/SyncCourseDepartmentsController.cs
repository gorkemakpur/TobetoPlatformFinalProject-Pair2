using Business.Abstracts;
using Business.Dtos.SyncCourseDepartment.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class SyncCourseDepartmentsController : BaseController
    {
        ISyncCourseDepartmentService _syncCourseDepartmentService;

        public SyncCourseDepartmentsController(ISyncCourseDepartmentService syncCourseDepartmentService)
        {
            _syncCourseDepartmentService = syncCourseDepartmentService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSyncCourseDepartmentRequest DeleteSyncCourseDepartmentRequest)
        {
            var result = await _syncCourseDepartmentService.DeleteAsync(DeleteSyncCourseDepartmentRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSyncCourseDepartmentRequest createSyncCourseDepartmentRequest)
        {
            var result = await _syncCourseDepartmentService.AddAsync(createSyncCourseDepartmentRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _syncCourseDepartmentService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _syncCourseDepartmentService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateSyncCourseDepartmentRequest updateSyncCourseDepartmentRequest)
        {
            var result = await _syncCourseDepartmentService.UpdateAsync(updateSyncCourseDepartmentRequest);
            return Ok(result);
        }
    }
}
