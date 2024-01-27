using Business.Abstracts;
using Business.Dtos.SyncCourseInstructor.Request;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class SyncCourseInstructorsController : BaseController
    {
        ISyncCourseInstructorService _syncCourseInstructorService;

        public SyncCourseInstructorsController(ISyncCourseInstructorService syncCourseInstructorService)
        {
            _syncCourseInstructorService = syncCourseInstructorService;
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteSyncCourseInstructorRequest DeleteSyncCourseInstructorRequest)
        {
            var result = await _syncCourseInstructorService.DeleteAsync(DeleteSyncCourseInstructorRequest);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateSyncCourseInstructorRequest createSyncCourseInstructorRequest)
        {
            var result = await _syncCourseInstructorService.AddAsync(createSyncCourseInstructorRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _syncCourseInstructorService.GetListAsync();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var result = await _syncCourseInstructorService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromQuery] UpdateSyncCourseInstructorRequest updateSyncCourseInstructorRequest)
        {
            var result = await _syncCourseInstructorService.UpdateAsync(updateSyncCourseInstructorRequest);
            return Ok(result);
        }
    }
}
